section .text
    global common

printString:
    .setup:
        mov ah, 0x0E                ; Select TTY mode

    .logic:
        mov al, [bx]

        cmp al, 0                   ; if al == 0
        je .return                  ; exit the loop

        int 0x10                    ; Print on screen interrupt
        inc bx                      ; bx++
        jmp .logic                  ; next loop iteration

    .return:
        ret

printOsName:
    .setup:
        mov bx, [osNameString]

    .logic:
        call printString

    .return:
        ret

printTime:
    .setup:
        mov ah, 0x00                ; Select Read RTC
        int 0x1A                    ; RTC sevice interrupt
        mov bx, 0x06                ; Set string offset

    .logic:
        mov dl, ch                  ; Get hours
        call setupTimeString

        mov dl, cl                  ; Get minutes
        call setupTimeString

        mov dl, dh                  ; Get seconds
        call setupTimeString

        mov bx, [timeString]
        call printString            ; Print "Time: hh:mm:ss"

    .return:
        ret

loadDisk:
    .setup:
        mov ah, 2
        mov al, 1                   ; Number of sectors
        mov ch, 0                   ; Cylinder number
        mov cl, 2                   ; Sector number
        mov dh, 0                   ; Head number
        mov dl, [diskNumber]        ; Disk number
        mov ax, 0x00                ; Push 0x00 to es hack

    .logic:
        mov es, ax
        mov bx, 0x7E00              ; 0x7C00 + 512 bytes
        int 0x13                    ; Load disk interrupt

    .return:
        ret

setupTimeString:
    .logic:
        mov al, dl
        shr al, 0x04                ; Skip one's place
        add al, 0x30                ; Add '0' character
        mov [timeString + bx], al   ; Set ten's place
        inc bx                      ; bh++

        mov al, dl
        shr al, 0x0F                ; Skip ten's place
        add al, 0x30
        mov [timeString + bx], al    ; Set one's place
        inc bx
    .return:
        ret

osNameString:
    db "CoolBeanOS 0.0.1 ", 0
timeString:
    db "Time: hh:mm:ss", 0

diskNumber:
    db 0, 0
