rm -rf build/
mkdir build

nasm -f bin src/common_private.asm -o build/common_private.o
nasm -f bin src/common.asm -o build/common.o
nasm -f bin src/boot.asm -o build/boot.o

cd build
cat boot.bin common.bin common_private.bin > bootloader.bin
cd ..