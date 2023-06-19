Remove-Item build
mkdir build

#nasm -f bin src/common_private.asm -o build/common_private.bin
#nasm -f bin src/common.asm -o build/common.bin
#nasm -f bin src/boot.asm -o build/boot.bin

#$boot           = [System.IO.File]::ReadAllBytes("build\boot.bin")
#$common         = [System.IO.File]::ReadAllBytes("build\common.bin")
#$common_private = [System.IO.File]::ReadAllBytes("build\common_private.bin")
#$bootloader = $common_private + $common + $boot
#[System.IO.File]::WriteAllBytes("build\bootloader.bin", $bootloader)

nasm -f elf src/common_private.asm -o build/common_private.obj
nasm -f elf src/common.asm -o build/common.obj
nasm -f elf src/boot.asm -o build/boot.obj

gcc -m32 -nostdlib -nodefaultlibs -lgcc boot/boot.obj boot/common.obj boot/common_private.obj -t src/linker.ld -o boot/linked_bootloader.bin

objcopy --input-target=elf32-little --output-target=binary boot/linked_bootloader.bin boot/bootloader.bin

Remove-Item .\build\boot.obj
Remove-Item .\build\common.obj
Remove-Item .\build\common_private.obj

VBoxManage convertfromraw build\bootloader.bin build\bootloader.vdi --format VHD
