nasm -f bin ".\Boot\src\boot.asm" -o ".\Boot\build\bootloader.bin"
nasm -f elf ".\Kernel\src\kernel_entry.asm" -o ".\Kernel\build\kernel_entry.o"
