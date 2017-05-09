.data
.cstring
	.align 2
LC0:
	.ascii "Hello World!\0"
.text
	.align 2
	.globl _main
_main:
	mflr r0
	stmw r30,-8(r1)
	stw r0,8(r1)
	stwu r1,-80(r1)
	mr r30,r1
	bcl 20,31,L1$pb
L1$pb:
	mflr r31
	addis r3,r31,ha16(LC0-L1$pb)
	la r3,lo16(LC0-L1$pb)(r3)
	bl L_puts$stub
	li r0,0
	mr r3,r0
	lwz r1,0(r1)
	lwz r0,8(r1)
	mtlr r0
	lmw r30,-8(r1)
	blr
.data
.picsymbol_stub
L_puts$stub:
	.indirect_symbol _puts
	mflr r0
	bcl 20,31,L0$_puts
L0$_puts:
	mflr r11
	addis r11,r11,ha16(L_puts$lazy_ptr-L0$_puts)
	mtlr r0
	lwz r12,lo16(L_puts$lazy_ptr-L0$_puts)(r11)
	mtctr r12
	addi r11,r11,lo16(L_puts$lazy_ptr-L0$_puts)
	bctr
.data
.lazy_symbol_pointer
L_puts$lazy_ptr:
	.indirect_symbol _puts
	.long dyld_stub_binding_helper
