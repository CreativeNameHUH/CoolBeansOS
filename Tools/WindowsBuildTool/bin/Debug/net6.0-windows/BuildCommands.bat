:: === AUTO GENERATED COMPILE COMMANDS AT: 18.06.2023 00:21:06 ===

:: === BOOT COMPILE COMMANDS ===

del "C:\DEV\OS\Boot\build"
mkdir "C:\DEV\OS\Boot\build"

"C:\Program Files\NASM\nasm" -f elf32 "C:\DEV\OS\Boot\src\boot.asm" -o "C:\DEV\OS\Boot\build\boot.obj"
"C:\Program Files\NASM\nasm" -f elf32 "C:\DEV\OS\Boot\src\common.asm" -o "C:\DEV\OS\Boot\build\common.obj"
"C:\Program Files\NASM\nasm" -f elf32 "C:\DEV\OS\Boot\src\trash.asm" -o "C:\DEV\OS\Boot\build\trash.obj"

"C:\msys64\mingw64\bin\gcc" -m32 -static -fno-asynchronous-unwind-tables -nostdlib -nodefaultlibs "C:\DEV\OS\Boot\build\boot.obj" "C:\DEV\OS\Boot\build\common.obj" "C:\DEV\OS\Boot\build\trash.obj"-T linker.ld -o "C:\DEV\OS\Boot\build\bootloader.bin"
objcopy -O binary "C:\DEV\OS\Boot\build\linked_bootloader.bin" "C:\DEV\OS\Boot\build\bootloader.bin"

del /f "C:\DEV\OS\Boot\build\boot.obj"
del /f "C:\DEV\OS\Boot\build\common.obj"
del /f "C:\DEV\OS\Boot\build\trash.obj"

:: === KERNEL COMPILE COMMANDS ===

del "C:\DEV\OS\Boot\build"
mkdir "C:\DEV\OS\Boot\build"


VBoxManage convertfromraw build\bootloader.bin build\bootloader.vdi --format VHD
