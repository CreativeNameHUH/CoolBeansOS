[org 0x7C00]                    ; Shift addresses
[bits 16]

jmp _boot

KERNEL_ADDRESS:
    equ 0x1000

DISK_NUMBER:
    db 0x00

CODE_SEGMENT:
    equ GDT_start.code - GDT_start
DATA_SEGMENT:
    equ GDT_start.data - GDT_start

GDT_start:
    .zero:
        dd 0x0
        dd 0x0
    
    .code:
        dw 0xFFFF
        dw 0x0000
        db 0x0000
        db 0x009A
        db 0x00CF
        db 0x0000
    
    .data:
        dw 0xFFFF
        dw 0x0000
        db 0x0000
        db 0x009A
        db 0x00CF
        db 0x0000

GDT_end:

GDT_descriptor:
    dw GDT_end - GDT_start - 1
    dd GDT_start

setupSegments:
    mov ds, ax
    mov es, ax
    mov ss, ax
    mov fs, ax
    mov gs, ax
    
    ret

setupMemory:
    cli
    mov ax, 0x00
    call setupSegments
    mov sp, 0x7C00
    sti

    ret

loadDisk:
    mov ah, 0x02
    mov al, 0x01                ; Number of sectors
    mov ch, 0x00                ; Cylinder number
    mov cl, 0x02                ; Sector number
    mov dh, 0x00                ; Head number
    mov dl, [DISK_NUMBER]       ; Disk number
    mov ax, 0x00                ; Push 0x00 to es hack

    mov es, ax
    mov bx, 0x7E00              ; 0x7C00 + 512 bytes
    int 0x13                    ; Load disk interrupt

    ret

_boot:
    mov [DISK_NUMBER], dl       ; Set boot disk number

    call setupMemory

    mov bx, KERNEL_ADDRESS
    mov dh, 2

    call loadDisk

    mov ah, 0x00                ; Clear the screen
    mov al, 0x03
    int 0x10

    cli
    lgdt [GDT_descriptor]
    mov eax, cr0
    or eax, 1
    mov cr0, eax
    jmp CODE_SEGMENT:_protected_mode

    jmp $

[bits 32]
_protected_mode:
    mov ax, DATA_SEGMENT
    call setupSegments

    mov ebp, 0x90000            ; 32 bit stack pointer
    mov esp, ebp

    jmp KERNEL_ADDRESS
    

times 510 - ($ - $$) db 0       ; Fills 510 bytes with 0s. ($ - $$) = 3. 3 + 510 - 3 = 510
db 0x55, 0xAA                   ; Last 2 bytes has to be 0x55 and 0xAA
