del build
mkdir build

nasm -f elf32 src/common_private.asm -o build/common_private.obj
nasm -f elf32 src/common.asm -o build/common.obj
nasm -f elf32 src/boot.asm -o build/boot.obj    

::objcopy -I binary -O elf32-i386 -B i386 boot.bin boot.o
::objcopy -I binary -O elf32-i386 -B i386 common.bin common.o
::objcopy -I binary -O elf32-i386 -B i386 common_private.bin common_.o

gcc -m32 -static -fno-asynchronous-unwind-tables -nostdlib -nodefaultlibs .\build\boot.obj .\build\common.obj .\build\common_private.obj -T linker.ld -o .\build\bootloader.bin
objcopy -O binary build/linked_bootloader.bin build/bootloader.bin

del /f build\boot.obj
del /f build\common.obj
del /f build\common_private.obj
::del /f build\linked_bootloader.bin

VBoxManage convertfromraw build\bootloader.bin build\bootloader.vdi --format VHD

cd ..
