// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

.assembly extern legacy library mscorlib {}
.assembly extern xunit.core {}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 4:0:0:0
}
.assembly 'fielda_tests_unaligned_1'{}

.class public field_tests {

.field			int8 i1Field
.field			int16 i2Field
.field			int32 i4Field
.field			int64 i8Field
.field			float32 r4Field
.field			float64 r8Field
.field			class field_tests ptrField

.field static	int8 i1SField
.field static	int16 i2SField
.field static	int32 i4SField
.field static	int64 i8SField
.field static	float32 r4SField
.field static	float64 r8SField
.field static	class field_tests ptrSField


//-------------------------
// Constructor     -
//-------------------------
.method void .ctor() {

.maxstack	10
	ldarg.0
	call instance void [mscorlib]System.Object::.ctor() 
	ret
}

//-------------------------
// Initialize     -
//-------------------------
.method	void initialize() {
.maxstack	10

	ldarg	0
	ldc.i4	0x1
	unaligned. 0x1
	stfld	int8 field_tests::i1Field
	//------
	ldarg	0
	ldc.i4	0x2
	unaligned. 0x1
	stfld	int16 field_tests::i2Field
	//------
	ldarg	0
	ldc.i4	0x4
	unaligned. 0x1
	stfld	int32 field_tests::i4Field
	//------
	ldarg	0
	ldc.i8	0x8
	unaligned. 0x1
	stfld	int64 field_tests::i8Field
	//------
	ldarg	0
	ldc.r4	4.4
	unaligned. 0x1
	stfld	float32 field_tests::r4Field
	//------
	ldarg	0
	ldc.r8	8.8
	unaligned. 0x1
	stfld	float64 field_tests::r8Field
	//------
	ldarg	0
	ldarg	0
	unaligned. 0x1
	stfld	class field_tests field_tests::ptrField
//-----------------
	ldc.i4	0x1
	stsfld	int8 field_tests::i1SField
	//------
	ldc.i4	0x2
	stsfld	int16 field_tests::i2SField
	//------
	ldc.i4	0x4
	stsfld	int32 field_tests::i4SField
	//------
	ldc.i8	0x8
	stsfld	int64 field_tests::i8SField
	//------
	ldc.r4	4.4
	stsfld	float32 field_tests::r4SField
	//------
	ldc.r8	8.8
	stsfld	float64 field_tests::r8SField
	//------
	ldarg	0
	stsfld	class field_tests field_tests::ptrSField


	ret
}

//-------------------------
// Entry point - Main     -
//-------------------------
.method public static int32 main() {
.custom instance void [xunit.core]Xunit.FactAttribute::.ctor() = (
    01 00 00 00
)
.entrypoint
.maxstack	10
.locals	(class field_tests)
//----------------
// begin field_testsing -
//----------------
	newobj	instance void field_tests::.ctor() 
	dup
	stloc	0
	call		instance void field_tests::initialize()
	//------------
	ldloc	0
	ldflda		int8 field_tests::i1Field
	unaligned. 0x1
	ldind.i1
	ldc.i4		0x1
	ceq
	brfalse		FAIL
	//-----
	ldloc	0
	ldflda		int16 field_tests::i2Field
	unaligned. 0x1
	ldind.i2
	ldc.i4		0x2
	ceq
	brfalse		FAIL
	//-----
	ldloc	0
	ldflda		int32 field_tests::i4Field
	unaligned. 0x1
	ldind.i4
	ldc.i4		0x4
	ceq
	brfalse		FAIL
	//-----
	ldloc	0
	ldflda		int64 field_tests::i8Field
	unaligned. 0x1
	ldind.i8
	ldc.i8		0x8
	ceq
	brfalse		FAIL
	//-----
	ldloc	0
	ldflda		float32 field_tests::r4Field
	unaligned. 0x1
	ldind.r4
	ldc.r4		4.4
	ceq
	brfalse		FAIL
	//-----
	ldloc	0
	ldflda		float64 field_tests::r8Field
	unaligned. 0x1
	ldind.r8
	ldc.r8		8.8
	ceq
	brfalse		FAIL
	//-----
	ldloc	0
	ldflda		class field_tests field_tests::ptrField
	ldind.ref
	isinst 		field_tests	
	brfalse		FAIL
//--------------------------------
	ldsflda	int8 field_tests::i1SField
	unaligned. 0x1
	ldind.i1
	ldc.i4	0x1
	ceq
	brfalse	FAIL
	//-----
	ldsflda	int16 field_tests::i2SField
	unaligned. 0x1
	ldind.i2
	ldc.i4	0x2
	ceq
	brfalse	FAIL
	//-----
	ldsflda	int32 field_tests::i4SField
	unaligned. 0x1
	ldind.i4
	ldc.i4	0x4
	ceq
	brfalse	FAIL
	//-----
	ldsflda	int64 field_tests::i8SField
	unaligned. 0x1
	ldind.i8
	ldc.i8	0x8
	ceq
	brfalse	FAIL
	//-----
	ldsflda	float32 field_tests::r4SField
	unaligned. 0x1
	ldind.r4
	ldc.r4	4.4
	ceq
	brfalse	FAIL
	//-----
	ldsflda	float64 field_tests::r8SField
	unaligned. 0x1
	ldind.r8
	ldc.r8	8.8
	ceq
	brfalse	FAIL
	//-----
	ldsflda	class field_tests field_tests::ptrSField
	unaligned. 0x1
	ldind.ref
	isinst	field_tests
	brfalse	FAIL

//----------------
PASS:
	ldc.i4	0x64
	ret
//----------------
FAIL:
	ldc.i4	0x0
	ret
}
}
