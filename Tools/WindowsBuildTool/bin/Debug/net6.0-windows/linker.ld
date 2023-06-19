ENTRY (_START)

SECTIONS
{
	. = 0x7c00;
	.text :
	{
		*(.text);
	}
}