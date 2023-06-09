// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*=====================================================================
**
** Source:    test4.c
**
** Purpose:   Test #4 for the _vsnprintf function.
**
**
**===================================================================*/

#include <palsuite.h>
#include "../_vsnprintf_s.h"

/*
 * Notes: memcmp is used, as is strlen.
 */

static void DoPointerTest(char *formatstr, void* param, char* paramstr,
                   char *checkstr1)
{
    char buf[256] = { 0 };

    Testvsnprintf(buf,256, formatstr, param);
    if (memcmp(buf, checkstr1, strlen(checkstr1) + 1) != 0)
    {
        Fail("ERROR: failed to insert %s into \"%s\"\n"
            "Expected \"%s\" got \"%s\".\n",
            paramstr, formatstr, checkstr1, buf);
    }
}

PALTEST(c_runtime__vsnprintf_s_test4_paltest_vsnprintf_test4, "c_runtime/_vsnprintf_s/test4/paltest_vsnprintf_test4")
{
    void *ptr = (void*) 0x123456;

    if (PAL_Initialize(argc, argv) != 0)
        return(FAIL);


	/*
     **  Run only on 64 bit platforms
     */
#if defined(HOST_64BIT)
	Trace("Testing for 64 Bit Platforms \n");
    DoPointerTest("%p", ptr, "pointer to 0x123456", "0x123456");
    DoPointerTest("%17p", ptr, "pointer to 0x123456", "         0x123456");
    DoPointerTest("%-17p", ptr, "pointer to 0x123456", "0x123456         ");

#else
	Trace("Testing for Non 64 Bit Platforms \n");
    DoPointerTest("%p", ptr, "pointer to 0x123456", "0x123456");
    DoPointerTest("%9p", ptr, "pointer to 0x123456", " 0x123456");
    DoPointerTest("%-9p", ptr, "pointer to 0x123456", "0x123456 ");
#endif

    PAL_Terminate();
    return PASS;
}

