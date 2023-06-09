// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
//

#pragma warning disable

using System;
using Xunit;
public class testout1
{
    static double static_field_double;
    static bool sfb_false;
    static bool sfb_true;
    double mfd;
    bool mfb_false;
    bool mfb_true;
    static double simple_func_double()
    {
        return 17.2222;
    }
    static bool func_sb_true()
    {
        return true;
    }
    static bool func_sb_false()
    {
        return false;
    }

    static double Sub_Funclet_0()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ true ? 3.1 : 3.1);
        Sum += (true ^ true ? 3.1 : -5.31);
        Sum += (true ^ true ? 3.1 : local_double);
        Sum += (true ^ true ? 3.1 : static_field_double);
        Sum += (true ^ true ? 3.1 : t1_i.mfd);
        Sum += (true ^ true ? 3.1 : simple_func_double());
        Sum += (true ^ true ? 3.1 : ab[index]);
        Sum += (true ^ true ? 3.1 : ab[index - 1]);
        Sum += (true ^ true ? -5.31 : 3.1);
        Sum += (true ^ true ? -5.31 : -5.31);
        Sum += (true ^ true ? -5.31 : local_double);
        Sum += (true ^ true ? -5.31 : static_field_double);
        Sum += (true ^ true ? -5.31 : t1_i.mfd);
        Sum += (true ^ true ? -5.31 : simple_func_double());
        Sum += (true ^ true ? -5.31 : ab[index]);
        Sum += (true ^ true ? -5.31 : ab[index - 1]);
        Sum += (true ^ true ? local_double : 3.1);
        Sum += (true ^ true ? local_double : -5.31);
        Sum += (true ^ true ? local_double : local_double);
        Sum += (true ^ true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_1()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ true ? local_double : t1_i.mfd);
        Sum += (true ^ true ? local_double : simple_func_double());
        Sum += (true ^ true ? local_double : ab[index]);
        Sum += (true ^ true ? local_double : ab[index - 1]);
        Sum += (true ^ true ? static_field_double : 3.1);
        Sum += (true ^ true ? static_field_double : -5.31);
        Sum += (true ^ true ? static_field_double : local_double);
        Sum += (true ^ true ? static_field_double : static_field_double);
        Sum += (true ^ true ? static_field_double : t1_i.mfd);
        Sum += (true ^ true ? static_field_double : simple_func_double());
        Sum += (true ^ true ? static_field_double : ab[index]);
        Sum += (true ^ true ? static_field_double : ab[index - 1]);
        Sum += (true ^ true ? t1_i.mfd : 3.1);
        Sum += (true ^ true ? t1_i.mfd : -5.31);
        Sum += (true ^ true ? t1_i.mfd : local_double);
        Sum += (true ^ true ? t1_i.mfd : static_field_double);
        Sum += (true ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ true ? t1_i.mfd : simple_func_double());
        Sum += (true ^ true ? t1_i.mfd : ab[index]);
        Sum += (true ^ true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_2()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ true ? simple_func_double() : 3.1);
        Sum += (true ^ true ? simple_func_double() : -5.31);
        Sum += (true ^ true ? simple_func_double() : local_double);
        Sum += (true ^ true ? simple_func_double() : static_field_double);
        Sum += (true ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ true ? simple_func_double() : simple_func_double());
        Sum += (true ^ true ? simple_func_double() : ab[index]);
        Sum += (true ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ true ? ab[index] : 3.1);
        Sum += (true ^ true ? ab[index] : -5.31);
        Sum += (true ^ true ? ab[index] : local_double);
        Sum += (true ^ true ? ab[index] : static_field_double);
        Sum += (true ^ true ? ab[index] : t1_i.mfd);
        Sum += (true ^ true ? ab[index] : simple_func_double());
        Sum += (true ^ true ? ab[index] : ab[index]);
        Sum += (true ^ true ? ab[index] : ab[index - 1]);
        Sum += (true ^ true ? ab[index - 1] : 3.1);
        Sum += (true ^ true ? ab[index - 1] : -5.31);
        Sum += (true ^ true ? ab[index - 1] : local_double);
        Sum += (true ^ true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_3()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ true ? ab[index - 1] : simple_func_double());
        Sum += (true ^ true ? ab[index - 1] : ab[index]);
        Sum += (true ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ false ? 3.1 : 3.1);
        Sum += (true ^ false ? 3.1 : -5.31);
        Sum += (true ^ false ? 3.1 : local_double);
        Sum += (true ^ false ? 3.1 : static_field_double);
        Sum += (true ^ false ? 3.1 : t1_i.mfd);
        Sum += (true ^ false ? 3.1 : simple_func_double());
        Sum += (true ^ false ? 3.1 : ab[index]);
        Sum += (true ^ false ? 3.1 : ab[index - 1]);
        Sum += (true ^ false ? -5.31 : 3.1);
        Sum += (true ^ false ? -5.31 : -5.31);
        Sum += (true ^ false ? -5.31 : local_double);
        Sum += (true ^ false ? -5.31 : static_field_double);
        Sum += (true ^ false ? -5.31 : t1_i.mfd);
        Sum += (true ^ false ? -5.31 : simple_func_double());
        Sum += (true ^ false ? -5.31 : ab[index]);
        Sum += (true ^ false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_4()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ false ? local_double : 3.1);
        Sum += (true ^ false ? local_double : -5.31);
        Sum += (true ^ false ? local_double : local_double);
        Sum += (true ^ false ? local_double : static_field_double);
        Sum += (true ^ false ? local_double : t1_i.mfd);
        Sum += (true ^ false ? local_double : simple_func_double());
        Sum += (true ^ false ? local_double : ab[index]);
        Sum += (true ^ false ? local_double : ab[index - 1]);
        Sum += (true ^ false ? static_field_double : 3.1);
        Sum += (true ^ false ? static_field_double : -5.31);
        Sum += (true ^ false ? static_field_double : local_double);
        Sum += (true ^ false ? static_field_double : static_field_double);
        Sum += (true ^ false ? static_field_double : t1_i.mfd);
        Sum += (true ^ false ? static_field_double : simple_func_double());
        Sum += (true ^ false ? static_field_double : ab[index]);
        Sum += (true ^ false ? static_field_double : ab[index - 1]);
        Sum += (true ^ false ? t1_i.mfd : 3.1);
        Sum += (true ^ false ? t1_i.mfd : -5.31);
        Sum += (true ^ false ? t1_i.mfd : local_double);
        Sum += (true ^ false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_5()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ false ? t1_i.mfd : simple_func_double());
        Sum += (true ^ false ? t1_i.mfd : ab[index]);
        Sum += (true ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ false ? simple_func_double() : 3.1);
        Sum += (true ^ false ? simple_func_double() : -5.31);
        Sum += (true ^ false ? simple_func_double() : local_double);
        Sum += (true ^ false ? simple_func_double() : static_field_double);
        Sum += (true ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ false ? simple_func_double() : simple_func_double());
        Sum += (true ^ false ? simple_func_double() : ab[index]);
        Sum += (true ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ false ? ab[index] : 3.1);
        Sum += (true ^ false ? ab[index] : -5.31);
        Sum += (true ^ false ? ab[index] : local_double);
        Sum += (true ^ false ? ab[index] : static_field_double);
        Sum += (true ^ false ? ab[index] : t1_i.mfd);
        Sum += (true ^ false ? ab[index] : simple_func_double());
        Sum += (true ^ false ? ab[index] : ab[index]);
        Sum += (true ^ false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_6()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ false ? ab[index - 1] : 3.1);
        Sum += (true ^ false ? ab[index - 1] : -5.31);
        Sum += (true ^ false ? ab[index - 1] : local_double);
        Sum += (true ^ false ? ab[index - 1] : static_field_double);
        Sum += (true ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ false ? ab[index - 1] : simple_func_double());
        Sum += (true ^ false ? ab[index - 1] : ab[index]);
        Sum += (true ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ lb_true ? 3.1 : 3.1);
        Sum += (true ^ lb_true ? 3.1 : -5.31);
        Sum += (true ^ lb_true ? 3.1 : local_double);
        Sum += (true ^ lb_true ? 3.1 : static_field_double);
        Sum += (true ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (true ^ lb_true ? 3.1 : simple_func_double());
        Sum += (true ^ lb_true ? 3.1 : ab[index]);
        Sum += (true ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (true ^ lb_true ? -5.31 : 3.1);
        Sum += (true ^ lb_true ? -5.31 : -5.31);
        Sum += (true ^ lb_true ? -5.31 : local_double);
        Sum += (true ^ lb_true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_7()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (true ^ lb_true ? -5.31 : simple_func_double());
        Sum += (true ^ lb_true ? -5.31 : ab[index]);
        Sum += (true ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (true ^ lb_true ? local_double : 3.1);
        Sum += (true ^ lb_true ? local_double : -5.31);
        Sum += (true ^ lb_true ? local_double : local_double);
        Sum += (true ^ lb_true ? local_double : static_field_double);
        Sum += (true ^ lb_true ? local_double : t1_i.mfd);
        Sum += (true ^ lb_true ? local_double : simple_func_double());
        Sum += (true ^ lb_true ? local_double : ab[index]);
        Sum += (true ^ lb_true ? local_double : ab[index - 1]);
        Sum += (true ^ lb_true ? static_field_double : 3.1);
        Sum += (true ^ lb_true ? static_field_double : -5.31);
        Sum += (true ^ lb_true ? static_field_double : local_double);
        Sum += (true ^ lb_true ? static_field_double : static_field_double);
        Sum += (true ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (true ^ lb_true ? static_field_double : simple_func_double());
        Sum += (true ^ lb_true ? static_field_double : ab[index]);
        Sum += (true ^ lb_true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_8()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (true ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (true ^ lb_true ? t1_i.mfd : local_double);
        Sum += (true ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (true ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (true ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (true ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ lb_true ? simple_func_double() : 3.1);
        Sum += (true ^ lb_true ? simple_func_double() : -5.31);
        Sum += (true ^ lb_true ? simple_func_double() : local_double);
        Sum += (true ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (true ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (true ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (true ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ lb_true ? ab[index] : 3.1);
        Sum += (true ^ lb_true ? ab[index] : -5.31);
        Sum += (true ^ lb_true ? ab[index] : local_double);
        Sum += (true ^ lb_true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_9()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (true ^ lb_true ? ab[index] : simple_func_double());
        Sum += (true ^ lb_true ? ab[index] : ab[index]);
        Sum += (true ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (true ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (true ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (true ^ lb_true ? ab[index - 1] : local_double);
        Sum += (true ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (true ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (true ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (true ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ lb_false ? 3.1 : 3.1);
        Sum += (true ^ lb_false ? 3.1 : -5.31);
        Sum += (true ^ lb_false ? 3.1 : local_double);
        Sum += (true ^ lb_false ? 3.1 : static_field_double);
        Sum += (true ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (true ^ lb_false ? 3.1 : simple_func_double());
        Sum += (true ^ lb_false ? 3.1 : ab[index]);
        Sum += (true ^ lb_false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_10()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ lb_false ? -5.31 : 3.1);
        Sum += (true ^ lb_false ? -5.31 : -5.31);
        Sum += (true ^ lb_false ? -5.31 : local_double);
        Sum += (true ^ lb_false ? -5.31 : static_field_double);
        Sum += (true ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (true ^ lb_false ? -5.31 : simple_func_double());
        Sum += (true ^ lb_false ? -5.31 : ab[index]);
        Sum += (true ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (true ^ lb_false ? local_double : 3.1);
        Sum += (true ^ lb_false ? local_double : -5.31);
        Sum += (true ^ lb_false ? local_double : local_double);
        Sum += (true ^ lb_false ? local_double : static_field_double);
        Sum += (true ^ lb_false ? local_double : t1_i.mfd);
        Sum += (true ^ lb_false ? local_double : simple_func_double());
        Sum += (true ^ lb_false ? local_double : ab[index]);
        Sum += (true ^ lb_false ? local_double : ab[index - 1]);
        Sum += (true ^ lb_false ? static_field_double : 3.1);
        Sum += (true ^ lb_false ? static_field_double : -5.31);
        Sum += (true ^ lb_false ? static_field_double : local_double);
        Sum += (true ^ lb_false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_11()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (true ^ lb_false ? static_field_double : simple_func_double());
        Sum += (true ^ lb_false ? static_field_double : ab[index]);
        Sum += (true ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (true ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (true ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (true ^ lb_false ? t1_i.mfd : local_double);
        Sum += (true ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (true ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (true ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (true ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ lb_false ? simple_func_double() : 3.1);
        Sum += (true ^ lb_false ? simple_func_double() : -5.31);
        Sum += (true ^ lb_false ? simple_func_double() : local_double);
        Sum += (true ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (true ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (true ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (true ^ lb_false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_12()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ lb_false ? ab[index] : 3.1);
        Sum += (true ^ lb_false ? ab[index] : -5.31);
        Sum += (true ^ lb_false ? ab[index] : local_double);
        Sum += (true ^ lb_false ? ab[index] : static_field_double);
        Sum += (true ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (true ^ lb_false ? ab[index] : simple_func_double());
        Sum += (true ^ lb_false ? ab[index] : ab[index]);
        Sum += (true ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (true ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (true ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (true ^ lb_false ? ab[index - 1] : local_double);
        Sum += (true ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (true ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (true ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (true ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ sfb_true ? 3.1 : 3.1);
        Sum += (true ^ sfb_true ? 3.1 : -5.31);
        Sum += (true ^ sfb_true ? 3.1 : local_double);
        Sum += (true ^ sfb_true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_13()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (true ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (true ^ sfb_true ? 3.1 : ab[index]);
        Sum += (true ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (true ^ sfb_true ? -5.31 : 3.1);
        Sum += (true ^ sfb_true ? -5.31 : -5.31);
        Sum += (true ^ sfb_true ? -5.31 : local_double);
        Sum += (true ^ sfb_true ? -5.31 : static_field_double);
        Sum += (true ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (true ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (true ^ sfb_true ? -5.31 : ab[index]);
        Sum += (true ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (true ^ sfb_true ? local_double : 3.1);
        Sum += (true ^ sfb_true ? local_double : -5.31);
        Sum += (true ^ sfb_true ? local_double : local_double);
        Sum += (true ^ sfb_true ? local_double : static_field_double);
        Sum += (true ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (true ^ sfb_true ? local_double : simple_func_double());
        Sum += (true ^ sfb_true ? local_double : ab[index]);
        Sum += (true ^ sfb_true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_14()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ sfb_true ? static_field_double : 3.1);
        Sum += (true ^ sfb_true ? static_field_double : -5.31);
        Sum += (true ^ sfb_true ? static_field_double : local_double);
        Sum += (true ^ sfb_true ? static_field_double : static_field_double);
        Sum += (true ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (true ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (true ^ sfb_true ? static_field_double : ab[index]);
        Sum += (true ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (true ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (true ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (true ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (true ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (true ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (true ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (true ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (true ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (true ^ sfb_true ? simple_func_double() : local_double);
        Sum += (true ^ sfb_true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_15()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (true ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (true ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ sfb_true ? ab[index] : 3.1);
        Sum += (true ^ sfb_true ? ab[index] : -5.31);
        Sum += (true ^ sfb_true ? ab[index] : local_double);
        Sum += (true ^ sfb_true ? ab[index] : static_field_double);
        Sum += (true ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (true ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (true ^ sfb_true ? ab[index] : ab[index]);
        Sum += (true ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (true ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (true ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (true ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (true ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (true ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (true ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (true ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_16()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ sfb_false ? 3.1 : 3.1);
        Sum += (true ^ sfb_false ? 3.1 : -5.31);
        Sum += (true ^ sfb_false ? 3.1 : local_double);
        Sum += (true ^ sfb_false ? 3.1 : static_field_double);
        Sum += (true ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (true ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (true ^ sfb_false ? 3.1 : ab[index]);
        Sum += (true ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (true ^ sfb_false ? -5.31 : 3.1);
        Sum += (true ^ sfb_false ? -5.31 : -5.31);
        Sum += (true ^ sfb_false ? -5.31 : local_double);
        Sum += (true ^ sfb_false ? -5.31 : static_field_double);
        Sum += (true ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (true ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (true ^ sfb_false ? -5.31 : ab[index]);
        Sum += (true ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (true ^ sfb_false ? local_double : 3.1);
        Sum += (true ^ sfb_false ? local_double : -5.31);
        Sum += (true ^ sfb_false ? local_double : local_double);
        Sum += (true ^ sfb_false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_17()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (true ^ sfb_false ? local_double : simple_func_double());
        Sum += (true ^ sfb_false ? local_double : ab[index]);
        Sum += (true ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (true ^ sfb_false ? static_field_double : 3.1);
        Sum += (true ^ sfb_false ? static_field_double : -5.31);
        Sum += (true ^ sfb_false ? static_field_double : local_double);
        Sum += (true ^ sfb_false ? static_field_double : static_field_double);
        Sum += (true ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (true ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (true ^ sfb_false ? static_field_double : ab[index]);
        Sum += (true ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (true ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (true ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (true ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (true ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (true ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (true ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (true ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_18()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (true ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (true ^ sfb_false ? simple_func_double() : local_double);
        Sum += (true ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (true ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (true ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (true ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ sfb_false ? ab[index] : 3.1);
        Sum += (true ^ sfb_false ? ab[index] : -5.31);
        Sum += (true ^ sfb_false ? ab[index] : local_double);
        Sum += (true ^ sfb_false ? ab[index] : static_field_double);
        Sum += (true ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (true ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (true ^ sfb_false ? ab[index] : ab[index]);
        Sum += (true ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (true ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (true ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (true ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (true ^ sfb_false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_19()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (true ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (true ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (true ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (true ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (true ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (true ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (true ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (true ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (true ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (true ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (true ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (true ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (true ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (true ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_20()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (true ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (true ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (true ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (true ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (true ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (true ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (true ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (true ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (true ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (true ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (true ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (true ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (true ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (true ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (true ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_21()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (true ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (true ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (true ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (true ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (true ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (true ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (true ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (true ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (true ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (true ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (true ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (true ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (true ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (true ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_22()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (true ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (true ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (true ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (true ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (true ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (true ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (true ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (true ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (true ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (true ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (true ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (true ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (true ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (true ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (true ^ t1_i.mfb_false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_23()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (true ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (true ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (true ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (true ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (true ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (true ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (true ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (true ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (true ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (true ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (true ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (true ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (true ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (true ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_24()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (true ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (true ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (true ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (true ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (true ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (true ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (true ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (true ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (true ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (true ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (true ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (true ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (true ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (true ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (true ^ t1_i.mfb_false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_25()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (true ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (true ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (true ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (true ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (true ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (true ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (true ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (true ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (true ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (true ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (true ^ func_sb_true() ? 3.1 : local_double);
        Sum += (true ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (true ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (true ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (true ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (true ^ func_sb_true() ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_26()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (true ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (true ^ func_sb_true() ? -5.31 : local_double);
        Sum += (true ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (true ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (true ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (true ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (true ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (true ^ func_sb_true() ? local_double : 3.1);
        Sum += (true ^ func_sb_true() ? local_double : -5.31);
        Sum += (true ^ func_sb_true() ? local_double : local_double);
        Sum += (true ^ func_sb_true() ? local_double : static_field_double);
        Sum += (true ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (true ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (true ^ func_sb_true() ? local_double : ab[index]);
        Sum += (true ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (true ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (true ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (true ^ func_sb_true() ? static_field_double : local_double);
        Sum += (true ^ func_sb_true() ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_27()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (true ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (true ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (true ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (true ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (true ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (true ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (true ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (true ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (true ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (true ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (true ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (true ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (true ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (true ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (true ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (true ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_28()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (true ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (true ^ func_sb_true() ? ab[index] : local_double);
        Sum += (true ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (true ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (true ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (true ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (true ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (true ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (true ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (true ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (true ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (true ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (true ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (true ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (true ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (true ^ func_sb_false() ? 3.1 : local_double);
        Sum += (true ^ func_sb_false() ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_29()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (true ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (true ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (true ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (true ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (true ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (true ^ func_sb_false() ? -5.31 : local_double);
        Sum += (true ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (true ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (true ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (true ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (true ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (true ^ func_sb_false() ? local_double : 3.1);
        Sum += (true ^ func_sb_false() ? local_double : -5.31);
        Sum += (true ^ func_sb_false() ? local_double : local_double);
        Sum += (true ^ func_sb_false() ? local_double : static_field_double);
        Sum += (true ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (true ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (true ^ func_sb_false() ? local_double : ab[index]);
        Sum += (true ^ func_sb_false() ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_30()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (true ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (true ^ func_sb_false() ? static_field_double : local_double);
        Sum += (true ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (true ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (true ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (true ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (true ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (true ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (true ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (true ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (true ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (true ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (true ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (true ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (true ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (true ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (true ^ func_sb_false() ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_31()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (true ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (true ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (true ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (true ^ func_sb_false() ? ab[index] : local_double);
        Sum += (true ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (true ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (true ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (true ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (true ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (true ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (true ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (true ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (true ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (true ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (true ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (true ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_32()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (true ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (true ^ ab_true[index] ? 3.1 : local_double);
        Sum += (true ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (true ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (true ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (true ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (true ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (true ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (true ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (true ^ ab_true[index] ? -5.31 : local_double);
        Sum += (true ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (true ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (true ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (true ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (true ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (true ^ ab_true[index] ? local_double : 3.1);
        Sum += (true ^ ab_true[index] ? local_double : -5.31);
        Sum += (true ^ ab_true[index] ? local_double : local_double);
        Sum += (true ^ ab_true[index] ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_33()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (true ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (true ^ ab_true[index] ? local_double : ab[index]);
        Sum += (true ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (true ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (true ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (true ^ ab_true[index] ? static_field_double : local_double);
        Sum += (true ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (true ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (true ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (true ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (true ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (true ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (true ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (true ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (true ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (true ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (true ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (true ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_34()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (true ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (true ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (true ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (true ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (true ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (true ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (true ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (true ^ ab_true[index] ? ab[index] : local_double);
        Sum += (true ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (true ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (true ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (true ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (true ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (true ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (true ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (true ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (true ^ ab_true[index] ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_35()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (true ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (true ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (true ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (true ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (true ^ ab_false[index] ? 3.1 : local_double);
        Sum += (true ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (true ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (true ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (true ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (true ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (true ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (true ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (true ^ ab_false[index] ? -5.31 : local_double);
        Sum += (true ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (true ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (true ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (true ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (true ^ ab_false[index] ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_36()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ ab_false[index] ? local_double : 3.1);
        Sum += (true ^ ab_false[index] ? local_double : -5.31);
        Sum += (true ^ ab_false[index] ? local_double : local_double);
        Sum += (true ^ ab_false[index] ? local_double : static_field_double);
        Sum += (true ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (true ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (true ^ ab_false[index] ? local_double : ab[index]);
        Sum += (true ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (true ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (true ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (true ^ ab_false[index] ? static_field_double : local_double);
        Sum += (true ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (true ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (true ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (true ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (true ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (true ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (true ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (true ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (true ^ ab_false[index] ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_37()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (true ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (true ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (true ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (true ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (true ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (true ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (true ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (true ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (true ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (true ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (true ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (true ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (true ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (true ^ ab_false[index] ? ab[index] : local_double);
        Sum += (true ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (true ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (true ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (true ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (true ^ ab_false[index] ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_38()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (true ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (true ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (true ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (true ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (true ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (true ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (true ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (true ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ true ? 3.1 : 3.1);
        Sum += (false ^ true ? 3.1 : -5.31);
        Sum += (false ^ true ? 3.1 : local_double);
        Sum += (false ^ true ? 3.1 : static_field_double);
        Sum += (false ^ true ? 3.1 : t1_i.mfd);
        Sum += (false ^ true ? 3.1 : simple_func_double());
        Sum += (false ^ true ? 3.1 : ab[index]);
        Sum += (false ^ true ? 3.1 : ab[index - 1]);
        Sum += (false ^ true ? -5.31 : 3.1);
        Sum += (false ^ true ? -5.31 : -5.31);
        Sum += (false ^ true ? -5.31 : local_double);
        Sum += (false ^ true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_39()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ true ? -5.31 : t1_i.mfd);
        Sum += (false ^ true ? -5.31 : simple_func_double());
        Sum += (false ^ true ? -5.31 : ab[index]);
        Sum += (false ^ true ? -5.31 : ab[index - 1]);
        Sum += (false ^ true ? local_double : 3.1);
        Sum += (false ^ true ? local_double : -5.31);
        Sum += (false ^ true ? local_double : local_double);
        Sum += (false ^ true ? local_double : static_field_double);
        Sum += (false ^ true ? local_double : t1_i.mfd);
        Sum += (false ^ true ? local_double : simple_func_double());
        Sum += (false ^ true ? local_double : ab[index]);
        Sum += (false ^ true ? local_double : ab[index - 1]);
        Sum += (false ^ true ? static_field_double : 3.1);
        Sum += (false ^ true ? static_field_double : -5.31);
        Sum += (false ^ true ? static_field_double : local_double);
        Sum += (false ^ true ? static_field_double : static_field_double);
        Sum += (false ^ true ? static_field_double : t1_i.mfd);
        Sum += (false ^ true ? static_field_double : simple_func_double());
        Sum += (false ^ true ? static_field_double : ab[index]);
        Sum += (false ^ true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_40()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ true ? t1_i.mfd : 3.1);
        Sum += (false ^ true ? t1_i.mfd : -5.31);
        Sum += (false ^ true ? t1_i.mfd : local_double);
        Sum += (false ^ true ? t1_i.mfd : static_field_double);
        Sum += (false ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ true ? t1_i.mfd : simple_func_double());
        Sum += (false ^ true ? t1_i.mfd : ab[index]);
        Sum += (false ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ true ? simple_func_double() : 3.1);
        Sum += (false ^ true ? simple_func_double() : -5.31);
        Sum += (false ^ true ? simple_func_double() : local_double);
        Sum += (false ^ true ? simple_func_double() : static_field_double);
        Sum += (false ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ true ? simple_func_double() : simple_func_double());
        Sum += (false ^ true ? simple_func_double() : ab[index]);
        Sum += (false ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ true ? ab[index] : 3.1);
        Sum += (false ^ true ? ab[index] : -5.31);
        Sum += (false ^ true ? ab[index] : local_double);
        Sum += (false ^ true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_41()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ true ? ab[index] : t1_i.mfd);
        Sum += (false ^ true ? ab[index] : simple_func_double());
        Sum += (false ^ true ? ab[index] : ab[index]);
        Sum += (false ^ true ? ab[index] : ab[index - 1]);
        Sum += (false ^ true ? ab[index - 1] : 3.1);
        Sum += (false ^ true ? ab[index - 1] : -5.31);
        Sum += (false ^ true ? ab[index - 1] : local_double);
        Sum += (false ^ true ? ab[index - 1] : static_field_double);
        Sum += (false ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ true ? ab[index - 1] : simple_func_double());
        Sum += (false ^ true ? ab[index - 1] : ab[index]);
        Sum += (false ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ false ? 3.1 : 3.1);
        Sum += (false ^ false ? 3.1 : -5.31);
        Sum += (false ^ false ? 3.1 : local_double);
        Sum += (false ^ false ? 3.1 : static_field_double);
        Sum += (false ^ false ? 3.1 : t1_i.mfd);
        Sum += (false ^ false ? 3.1 : simple_func_double());
        Sum += (false ^ false ? 3.1 : ab[index]);
        Sum += (false ^ false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_42()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ false ? -5.31 : 3.1);
        Sum += (false ^ false ? -5.31 : -5.31);
        Sum += (false ^ false ? -5.31 : local_double);
        Sum += (false ^ false ? -5.31 : static_field_double);
        Sum += (false ^ false ? -5.31 : t1_i.mfd);
        Sum += (false ^ false ? -5.31 : simple_func_double());
        Sum += (false ^ false ? -5.31 : ab[index]);
        Sum += (false ^ false ? -5.31 : ab[index - 1]);
        Sum += (false ^ false ? local_double : 3.1);
        Sum += (false ^ false ? local_double : -5.31);
        Sum += (false ^ false ? local_double : local_double);
        Sum += (false ^ false ? local_double : static_field_double);
        Sum += (false ^ false ? local_double : t1_i.mfd);
        Sum += (false ^ false ? local_double : simple_func_double());
        Sum += (false ^ false ? local_double : ab[index]);
        Sum += (false ^ false ? local_double : ab[index - 1]);
        Sum += (false ^ false ? static_field_double : 3.1);
        Sum += (false ^ false ? static_field_double : -5.31);
        Sum += (false ^ false ? static_field_double : local_double);
        Sum += (false ^ false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_43()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ false ? static_field_double : t1_i.mfd);
        Sum += (false ^ false ? static_field_double : simple_func_double());
        Sum += (false ^ false ? static_field_double : ab[index]);
        Sum += (false ^ false ? static_field_double : ab[index - 1]);
        Sum += (false ^ false ? t1_i.mfd : 3.1);
        Sum += (false ^ false ? t1_i.mfd : -5.31);
        Sum += (false ^ false ? t1_i.mfd : local_double);
        Sum += (false ^ false ? t1_i.mfd : static_field_double);
        Sum += (false ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ false ? t1_i.mfd : simple_func_double());
        Sum += (false ^ false ? t1_i.mfd : ab[index]);
        Sum += (false ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ false ? simple_func_double() : 3.1);
        Sum += (false ^ false ? simple_func_double() : -5.31);
        Sum += (false ^ false ? simple_func_double() : local_double);
        Sum += (false ^ false ? simple_func_double() : static_field_double);
        Sum += (false ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ false ? simple_func_double() : simple_func_double());
        Sum += (false ^ false ? simple_func_double() : ab[index]);
        Sum += (false ^ false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_44()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ false ? ab[index] : 3.1);
        Sum += (false ^ false ? ab[index] : -5.31);
        Sum += (false ^ false ? ab[index] : local_double);
        Sum += (false ^ false ? ab[index] : static_field_double);
        Sum += (false ^ false ? ab[index] : t1_i.mfd);
        Sum += (false ^ false ? ab[index] : simple_func_double());
        Sum += (false ^ false ? ab[index] : ab[index]);
        Sum += (false ^ false ? ab[index] : ab[index - 1]);
        Sum += (false ^ false ? ab[index - 1] : 3.1);
        Sum += (false ^ false ? ab[index - 1] : -5.31);
        Sum += (false ^ false ? ab[index - 1] : local_double);
        Sum += (false ^ false ? ab[index - 1] : static_field_double);
        Sum += (false ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ false ? ab[index - 1] : simple_func_double());
        Sum += (false ^ false ? ab[index - 1] : ab[index]);
        Sum += (false ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ lb_true ? 3.1 : 3.1);
        Sum += (false ^ lb_true ? 3.1 : -5.31);
        Sum += (false ^ lb_true ? 3.1 : local_double);
        Sum += (false ^ lb_true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_45()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (false ^ lb_true ? 3.1 : simple_func_double());
        Sum += (false ^ lb_true ? 3.1 : ab[index]);
        Sum += (false ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (false ^ lb_true ? -5.31 : 3.1);
        Sum += (false ^ lb_true ? -5.31 : -5.31);
        Sum += (false ^ lb_true ? -5.31 : local_double);
        Sum += (false ^ lb_true ? -5.31 : static_field_double);
        Sum += (false ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (false ^ lb_true ? -5.31 : simple_func_double());
        Sum += (false ^ lb_true ? -5.31 : ab[index]);
        Sum += (false ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (false ^ lb_true ? local_double : 3.1);
        Sum += (false ^ lb_true ? local_double : -5.31);
        Sum += (false ^ lb_true ? local_double : local_double);
        Sum += (false ^ lb_true ? local_double : static_field_double);
        Sum += (false ^ lb_true ? local_double : t1_i.mfd);
        Sum += (false ^ lb_true ? local_double : simple_func_double());
        Sum += (false ^ lb_true ? local_double : ab[index]);
        Sum += (false ^ lb_true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_46()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ lb_true ? static_field_double : 3.1);
        Sum += (false ^ lb_true ? static_field_double : -5.31);
        Sum += (false ^ lb_true ? static_field_double : local_double);
        Sum += (false ^ lb_true ? static_field_double : static_field_double);
        Sum += (false ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (false ^ lb_true ? static_field_double : simple_func_double());
        Sum += (false ^ lb_true ? static_field_double : ab[index]);
        Sum += (false ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (false ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (false ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (false ^ lb_true ? t1_i.mfd : local_double);
        Sum += (false ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (false ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (false ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (false ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ lb_true ? simple_func_double() : 3.1);
        Sum += (false ^ lb_true ? simple_func_double() : -5.31);
        Sum += (false ^ lb_true ? simple_func_double() : local_double);
        Sum += (false ^ lb_true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_47()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (false ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (false ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ lb_true ? ab[index] : 3.1);
        Sum += (false ^ lb_true ? ab[index] : -5.31);
        Sum += (false ^ lb_true ? ab[index] : local_double);
        Sum += (false ^ lb_true ? ab[index] : static_field_double);
        Sum += (false ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (false ^ lb_true ? ab[index] : simple_func_double());
        Sum += (false ^ lb_true ? ab[index] : ab[index]);
        Sum += (false ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (false ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (false ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (false ^ lb_true ? ab[index - 1] : local_double);
        Sum += (false ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (false ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (false ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (false ^ lb_true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_48()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ lb_false ? 3.1 : 3.1);
        Sum += (false ^ lb_false ? 3.1 : -5.31);
        Sum += (false ^ lb_false ? 3.1 : local_double);
        Sum += (false ^ lb_false ? 3.1 : static_field_double);
        Sum += (false ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (false ^ lb_false ? 3.1 : simple_func_double());
        Sum += (false ^ lb_false ? 3.1 : ab[index]);
        Sum += (false ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (false ^ lb_false ? -5.31 : 3.1);
        Sum += (false ^ lb_false ? -5.31 : -5.31);
        Sum += (false ^ lb_false ? -5.31 : local_double);
        Sum += (false ^ lb_false ? -5.31 : static_field_double);
        Sum += (false ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (false ^ lb_false ? -5.31 : simple_func_double());
        Sum += (false ^ lb_false ? -5.31 : ab[index]);
        Sum += (false ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (false ^ lb_false ? local_double : 3.1);
        Sum += (false ^ lb_false ? local_double : -5.31);
        Sum += (false ^ lb_false ? local_double : local_double);
        Sum += (false ^ lb_false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_49()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ lb_false ? local_double : t1_i.mfd);
        Sum += (false ^ lb_false ? local_double : simple_func_double());
        Sum += (false ^ lb_false ? local_double : ab[index]);
        Sum += (false ^ lb_false ? local_double : ab[index - 1]);
        Sum += (false ^ lb_false ? static_field_double : 3.1);
        Sum += (false ^ lb_false ? static_field_double : -5.31);
        Sum += (false ^ lb_false ? static_field_double : local_double);
        Sum += (false ^ lb_false ? static_field_double : static_field_double);
        Sum += (false ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (false ^ lb_false ? static_field_double : simple_func_double());
        Sum += (false ^ lb_false ? static_field_double : ab[index]);
        Sum += (false ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (false ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (false ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (false ^ lb_false ? t1_i.mfd : local_double);
        Sum += (false ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (false ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (false ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (false ^ lb_false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_50()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ lb_false ? simple_func_double() : 3.1);
        Sum += (false ^ lb_false ? simple_func_double() : -5.31);
        Sum += (false ^ lb_false ? simple_func_double() : local_double);
        Sum += (false ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (false ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (false ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (false ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ lb_false ? ab[index] : 3.1);
        Sum += (false ^ lb_false ? ab[index] : -5.31);
        Sum += (false ^ lb_false ? ab[index] : local_double);
        Sum += (false ^ lb_false ? ab[index] : static_field_double);
        Sum += (false ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (false ^ lb_false ? ab[index] : simple_func_double());
        Sum += (false ^ lb_false ? ab[index] : ab[index]);
        Sum += (false ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (false ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (false ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (false ^ lb_false ? ab[index - 1] : local_double);
        Sum += (false ^ lb_false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_51()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (false ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (false ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ sfb_true ? 3.1 : 3.1);
        Sum += (false ^ sfb_true ? 3.1 : -5.31);
        Sum += (false ^ sfb_true ? 3.1 : local_double);
        Sum += (false ^ sfb_true ? 3.1 : static_field_double);
        Sum += (false ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (false ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (false ^ sfb_true ? 3.1 : ab[index]);
        Sum += (false ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (false ^ sfb_true ? -5.31 : 3.1);
        Sum += (false ^ sfb_true ? -5.31 : -5.31);
        Sum += (false ^ sfb_true ? -5.31 : local_double);
        Sum += (false ^ sfb_true ? -5.31 : static_field_double);
        Sum += (false ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (false ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (false ^ sfb_true ? -5.31 : ab[index]);
        Sum += (false ^ sfb_true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_52()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ sfb_true ? local_double : 3.1);
        Sum += (false ^ sfb_true ? local_double : -5.31);
        Sum += (false ^ sfb_true ? local_double : local_double);
        Sum += (false ^ sfb_true ? local_double : static_field_double);
        Sum += (false ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (false ^ sfb_true ? local_double : simple_func_double());
        Sum += (false ^ sfb_true ? local_double : ab[index]);
        Sum += (false ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (false ^ sfb_true ? static_field_double : 3.1);
        Sum += (false ^ sfb_true ? static_field_double : -5.31);
        Sum += (false ^ sfb_true ? static_field_double : local_double);
        Sum += (false ^ sfb_true ? static_field_double : static_field_double);
        Sum += (false ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (false ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (false ^ sfb_true ? static_field_double : ab[index]);
        Sum += (false ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (false ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (false ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (false ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (false ^ sfb_true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_53()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (false ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (false ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (false ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (false ^ sfb_true ? simple_func_double() : local_double);
        Sum += (false ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (false ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (false ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (false ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ sfb_true ? ab[index] : 3.1);
        Sum += (false ^ sfb_true ? ab[index] : -5.31);
        Sum += (false ^ sfb_true ? ab[index] : local_double);
        Sum += (false ^ sfb_true ? ab[index] : static_field_double);
        Sum += (false ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (false ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (false ^ sfb_true ? ab[index] : ab[index]);
        Sum += (false ^ sfb_true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_54()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (false ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (false ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (false ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (false ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (false ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (false ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ sfb_false ? 3.1 : 3.1);
        Sum += (false ^ sfb_false ? 3.1 : -5.31);
        Sum += (false ^ sfb_false ? 3.1 : local_double);
        Sum += (false ^ sfb_false ? 3.1 : static_field_double);
        Sum += (false ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (false ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (false ^ sfb_false ? 3.1 : ab[index]);
        Sum += (false ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (false ^ sfb_false ? -5.31 : 3.1);
        Sum += (false ^ sfb_false ? -5.31 : -5.31);
        Sum += (false ^ sfb_false ? -5.31 : local_double);
        Sum += (false ^ sfb_false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_55()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (false ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (false ^ sfb_false ? -5.31 : ab[index]);
        Sum += (false ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (false ^ sfb_false ? local_double : 3.1);
        Sum += (false ^ sfb_false ? local_double : -5.31);
        Sum += (false ^ sfb_false ? local_double : local_double);
        Sum += (false ^ sfb_false ? local_double : static_field_double);
        Sum += (false ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (false ^ sfb_false ? local_double : simple_func_double());
        Sum += (false ^ sfb_false ? local_double : ab[index]);
        Sum += (false ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (false ^ sfb_false ? static_field_double : 3.1);
        Sum += (false ^ sfb_false ? static_field_double : -5.31);
        Sum += (false ^ sfb_false ? static_field_double : local_double);
        Sum += (false ^ sfb_false ? static_field_double : static_field_double);
        Sum += (false ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (false ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (false ^ sfb_false ? static_field_double : ab[index]);
        Sum += (false ^ sfb_false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_56()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (false ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (false ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (false ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (false ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (false ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (false ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (false ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (false ^ sfb_false ? simple_func_double() : local_double);
        Sum += (false ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (false ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (false ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (false ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ sfb_false ? ab[index] : 3.1);
        Sum += (false ^ sfb_false ? ab[index] : -5.31);
        Sum += (false ^ sfb_false ? ab[index] : local_double);
        Sum += (false ^ sfb_false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_57()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (false ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (false ^ sfb_false ? ab[index] : ab[index]);
        Sum += (false ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (false ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (false ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (false ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (false ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (false ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (false ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (false ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (false ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (false ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (false ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (false ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (false ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (false ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_58()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (false ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (false ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (false ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (false ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (false ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (false ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (false ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (false ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (false ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (false ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (false ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (false ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (false ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (false ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (false ^ t1_i.mfb_true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_59()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (false ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (false ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (false ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (false ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (false ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (false ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (false ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (false ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (false ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (false ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (false ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (false ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (false ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (false ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_60()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (false ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (false ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (false ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (false ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (false ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (false ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (false ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (false ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (false ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (false ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (false ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (false ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (false ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (false ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (false ^ t1_i.mfb_false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_61()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (false ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (false ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (false ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (false ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (false ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (false ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (false ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (false ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (false ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (false ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (false ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (false ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (false ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (false ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_62()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (false ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (false ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (false ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (false ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (false ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (false ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (false ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (false ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (false ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (false ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (false ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (false ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (false ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (false ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (false ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_63()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (false ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (false ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (false ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (false ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (false ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (false ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (false ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (false ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (false ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (false ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (false ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (false ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (false ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (false ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (false ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_64()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (false ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (false ^ func_sb_true() ? 3.1 : local_double);
        Sum += (false ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (false ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (false ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (false ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (false ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (false ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (false ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (false ^ func_sb_true() ? -5.31 : local_double);
        Sum += (false ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (false ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (false ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (false ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (false ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (false ^ func_sb_true() ? local_double : 3.1);
        Sum += (false ^ func_sb_true() ? local_double : -5.31);
        Sum += (false ^ func_sb_true() ? local_double : local_double);
        Sum += (false ^ func_sb_true() ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_65()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (false ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (false ^ func_sb_true() ? local_double : ab[index]);
        Sum += (false ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (false ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (false ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (false ^ func_sb_true() ? static_field_double : local_double);
        Sum += (false ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (false ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (false ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (false ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (false ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (false ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (false ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (false ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (false ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (false ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (false ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (false ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_66()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (false ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (false ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (false ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (false ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (false ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (false ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (false ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (false ^ func_sb_true() ? ab[index] : local_double);
        Sum += (false ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (false ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (false ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (false ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (false ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (false ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (false ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (false ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (false ^ func_sb_true() ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_67()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (false ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (false ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (false ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (false ^ func_sb_false() ? 3.1 : local_double);
        Sum += (false ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (false ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (false ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (false ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (false ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (false ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (false ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (false ^ func_sb_false() ? -5.31 : local_double);
        Sum += (false ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (false ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (false ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (false ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (false ^ func_sb_false() ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_68()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ func_sb_false() ? local_double : 3.1);
        Sum += (false ^ func_sb_false() ? local_double : -5.31);
        Sum += (false ^ func_sb_false() ? local_double : local_double);
        Sum += (false ^ func_sb_false() ? local_double : static_field_double);
        Sum += (false ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (false ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (false ^ func_sb_false() ? local_double : ab[index]);
        Sum += (false ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (false ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (false ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (false ^ func_sb_false() ? static_field_double : local_double);
        Sum += (false ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (false ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (false ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (false ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (false ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (false ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (false ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (false ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (false ^ func_sb_false() ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_69()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (false ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (false ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (false ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (false ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (false ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (false ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (false ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (false ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (false ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (false ^ func_sb_false() ? ab[index] : local_double);
        Sum += (false ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (false ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (false ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (false ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (false ^ func_sb_false() ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_70()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (false ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (false ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (false ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (false ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (false ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (false ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (false ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (false ^ ab_true[index] ? 3.1 : local_double);
        Sum += (false ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (false ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (false ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (false ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (false ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (false ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (false ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (false ^ ab_true[index] ? -5.31 : local_double);
        Sum += (false ^ ab_true[index] ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_71()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (false ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (false ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (false ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (false ^ ab_true[index] ? local_double : 3.1);
        Sum += (false ^ ab_true[index] ? local_double : -5.31);
        Sum += (false ^ ab_true[index] ? local_double : local_double);
        Sum += (false ^ ab_true[index] ? local_double : static_field_double);
        Sum += (false ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (false ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (false ^ ab_true[index] ? local_double : ab[index]);
        Sum += (false ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (false ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (false ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (false ^ ab_true[index] ? static_field_double : local_double);
        Sum += (false ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (false ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (false ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (false ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (false ^ ab_true[index] ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_72()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (false ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (false ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (false ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (false ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (false ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (false ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (false ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (false ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (false ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (false ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (false ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (false ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (false ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (false ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (false ^ ab_true[index] ? ab[index] : local_double);
        Sum += (false ^ ab_true[index] ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_73()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (false ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (false ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (false ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (false ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (false ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (false ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (false ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (false ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (false ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (false ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (false ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (false ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (false ^ ab_false[index] ? 3.1 : local_double);
        Sum += (false ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (false ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (false ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (false ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (false ^ ab_false[index] ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_74()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (false ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (false ^ ab_false[index] ? -5.31 : local_double);
        Sum += (false ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (false ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (false ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (false ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (false ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (false ^ ab_false[index] ? local_double : 3.1);
        Sum += (false ^ ab_false[index] ? local_double : -5.31);
        Sum += (false ^ ab_false[index] ? local_double : local_double);
        Sum += (false ^ ab_false[index] ? local_double : static_field_double);
        Sum += (false ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (false ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (false ^ ab_false[index] ? local_double : ab[index]);
        Sum += (false ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (false ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (false ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (false ^ ab_false[index] ? static_field_double : local_double);
        Sum += (false ^ ab_false[index] ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_75()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (false ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (false ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (false ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (false ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (false ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (false ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (false ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (false ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (false ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (false ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (false ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (false ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (false ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (false ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (false ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (false ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (false ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (false ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (false ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_76()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (false ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (false ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (false ^ ab_false[index] ? ab[index] : local_double);
        Sum += (false ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (false ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (false ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (false ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (false ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (false ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (false ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (false ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (false ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (false ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (false ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (false ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (false ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ true ? 3.1 : 3.1);
        Sum += (lb_true ^ true ? 3.1 : -5.31);
        Sum += (lb_true ^ true ? 3.1 : local_double);
        Sum += (lb_true ^ true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_77()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ true ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ true ? 3.1 : simple_func_double());
        Sum += (lb_true ^ true ? 3.1 : ab[index]);
        Sum += (lb_true ^ true ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ true ? -5.31 : 3.1);
        Sum += (lb_true ^ true ? -5.31 : -5.31);
        Sum += (lb_true ^ true ? -5.31 : local_double);
        Sum += (lb_true ^ true ? -5.31 : static_field_double);
        Sum += (lb_true ^ true ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ true ? -5.31 : simple_func_double());
        Sum += (lb_true ^ true ? -5.31 : ab[index]);
        Sum += (lb_true ^ true ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ true ? local_double : 3.1);
        Sum += (lb_true ^ true ? local_double : -5.31);
        Sum += (lb_true ^ true ? local_double : local_double);
        Sum += (lb_true ^ true ? local_double : static_field_double);
        Sum += (lb_true ^ true ? local_double : t1_i.mfd);
        Sum += (lb_true ^ true ? local_double : simple_func_double());
        Sum += (lb_true ^ true ? local_double : ab[index]);
        Sum += (lb_true ^ true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_78()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ true ? static_field_double : 3.1);
        Sum += (lb_true ^ true ? static_field_double : -5.31);
        Sum += (lb_true ^ true ? static_field_double : local_double);
        Sum += (lb_true ^ true ? static_field_double : static_field_double);
        Sum += (lb_true ^ true ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ true ? static_field_double : simple_func_double());
        Sum += (lb_true ^ true ? static_field_double : ab[index]);
        Sum += (lb_true ^ true ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ true ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ true ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ true ? t1_i.mfd : local_double);
        Sum += (lb_true ^ true ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ true ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ true ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ true ? simple_func_double() : 3.1);
        Sum += (lb_true ^ true ? simple_func_double() : -5.31);
        Sum += (lb_true ^ true ? simple_func_double() : local_double);
        Sum += (lb_true ^ true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_79()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ true ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ true ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ true ? ab[index] : 3.1);
        Sum += (lb_true ^ true ? ab[index] : -5.31);
        Sum += (lb_true ^ true ? ab[index] : local_double);
        Sum += (lb_true ^ true ? ab[index] : static_field_double);
        Sum += (lb_true ^ true ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ true ? ab[index] : simple_func_double());
        Sum += (lb_true ^ true ? ab[index] : ab[index]);
        Sum += (lb_true ^ true ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ true ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ true ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ true ? ab[index - 1] : local_double);
        Sum += (lb_true ^ true ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ true ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ true ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_80()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ false ? 3.1 : 3.1);
        Sum += (lb_true ^ false ? 3.1 : -5.31);
        Sum += (lb_true ^ false ? 3.1 : local_double);
        Sum += (lb_true ^ false ? 3.1 : static_field_double);
        Sum += (lb_true ^ false ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ false ? 3.1 : simple_func_double());
        Sum += (lb_true ^ false ? 3.1 : ab[index]);
        Sum += (lb_true ^ false ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ false ? -5.31 : 3.1);
        Sum += (lb_true ^ false ? -5.31 : -5.31);
        Sum += (lb_true ^ false ? -5.31 : local_double);
        Sum += (lb_true ^ false ? -5.31 : static_field_double);
        Sum += (lb_true ^ false ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ false ? -5.31 : simple_func_double());
        Sum += (lb_true ^ false ? -5.31 : ab[index]);
        Sum += (lb_true ^ false ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ false ? local_double : 3.1);
        Sum += (lb_true ^ false ? local_double : -5.31);
        Sum += (lb_true ^ false ? local_double : local_double);
        Sum += (lb_true ^ false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_81()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ false ? local_double : t1_i.mfd);
        Sum += (lb_true ^ false ? local_double : simple_func_double());
        Sum += (lb_true ^ false ? local_double : ab[index]);
        Sum += (lb_true ^ false ? local_double : ab[index - 1]);
        Sum += (lb_true ^ false ? static_field_double : 3.1);
        Sum += (lb_true ^ false ? static_field_double : -5.31);
        Sum += (lb_true ^ false ? static_field_double : local_double);
        Sum += (lb_true ^ false ? static_field_double : static_field_double);
        Sum += (lb_true ^ false ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ false ? static_field_double : simple_func_double());
        Sum += (lb_true ^ false ? static_field_double : ab[index]);
        Sum += (lb_true ^ false ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ false ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ false ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ false ? t1_i.mfd : local_double);
        Sum += (lb_true ^ false ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ false ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ false ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_82()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ false ? simple_func_double() : 3.1);
        Sum += (lb_true ^ false ? simple_func_double() : -5.31);
        Sum += (lb_true ^ false ? simple_func_double() : local_double);
        Sum += (lb_true ^ false ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ false ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ false ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ false ? ab[index] : 3.1);
        Sum += (lb_true ^ false ? ab[index] : -5.31);
        Sum += (lb_true ^ false ? ab[index] : local_double);
        Sum += (lb_true ^ false ? ab[index] : static_field_double);
        Sum += (lb_true ^ false ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ false ? ab[index] : simple_func_double());
        Sum += (lb_true ^ false ? ab[index] : ab[index]);
        Sum += (lb_true ^ false ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ false ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ false ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ false ? ab[index - 1] : local_double);
        Sum += (lb_true ^ false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_83()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ false ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ false ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ lb_true ? 3.1 : 3.1);
        Sum += (lb_true ^ lb_true ? 3.1 : -5.31);
        Sum += (lb_true ^ lb_true ? 3.1 : local_double);
        Sum += (lb_true ^ lb_true ? 3.1 : static_field_double);
        Sum += (lb_true ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ lb_true ? 3.1 : simple_func_double());
        Sum += (lb_true ^ lb_true ? 3.1 : ab[index]);
        Sum += (lb_true ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ lb_true ? -5.31 : 3.1);
        Sum += (lb_true ^ lb_true ? -5.31 : -5.31);
        Sum += (lb_true ^ lb_true ? -5.31 : local_double);
        Sum += (lb_true ^ lb_true ? -5.31 : static_field_double);
        Sum += (lb_true ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ lb_true ? -5.31 : simple_func_double());
        Sum += (lb_true ^ lb_true ? -5.31 : ab[index]);
        Sum += (lb_true ^ lb_true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_84()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ lb_true ? local_double : 3.1);
        Sum += (lb_true ^ lb_true ? local_double : -5.31);
        Sum += (lb_true ^ lb_true ? local_double : local_double);
        Sum += (lb_true ^ lb_true ? local_double : static_field_double);
        Sum += (lb_true ^ lb_true ? local_double : t1_i.mfd);
        Sum += (lb_true ^ lb_true ? local_double : simple_func_double());
        Sum += (lb_true ^ lb_true ? local_double : ab[index]);
        Sum += (lb_true ^ lb_true ? local_double : ab[index - 1]);
        Sum += (lb_true ^ lb_true ? static_field_double : 3.1);
        Sum += (lb_true ^ lb_true ? static_field_double : -5.31);
        Sum += (lb_true ^ lb_true ? static_field_double : local_double);
        Sum += (lb_true ^ lb_true ? static_field_double : static_field_double);
        Sum += (lb_true ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ lb_true ? static_field_double : simple_func_double());
        Sum += (lb_true ^ lb_true ? static_field_double : ab[index]);
        Sum += (lb_true ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ lb_true ? t1_i.mfd : local_double);
        Sum += (lb_true ^ lb_true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_85()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ lb_true ? simple_func_double() : 3.1);
        Sum += (lb_true ^ lb_true ? simple_func_double() : -5.31);
        Sum += (lb_true ^ lb_true ? simple_func_double() : local_double);
        Sum += (lb_true ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ lb_true ? ab[index] : 3.1);
        Sum += (lb_true ^ lb_true ? ab[index] : -5.31);
        Sum += (lb_true ^ lb_true ? ab[index] : local_double);
        Sum += (lb_true ^ lb_true ? ab[index] : static_field_double);
        Sum += (lb_true ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ lb_true ? ab[index] : simple_func_double());
        Sum += (lb_true ^ lb_true ? ab[index] : ab[index]);
        Sum += (lb_true ^ lb_true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_86()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ lb_true ? ab[index - 1] : local_double);
        Sum += (lb_true ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ lb_false ? 3.1 : 3.1);
        Sum += (lb_true ^ lb_false ? 3.1 : -5.31);
        Sum += (lb_true ^ lb_false ? 3.1 : local_double);
        Sum += (lb_true ^ lb_false ? 3.1 : static_field_double);
        Sum += (lb_true ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ lb_false ? 3.1 : simple_func_double());
        Sum += (lb_true ^ lb_false ? 3.1 : ab[index]);
        Sum += (lb_true ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ lb_false ? -5.31 : 3.1);
        Sum += (lb_true ^ lb_false ? -5.31 : -5.31);
        Sum += (lb_true ^ lb_false ? -5.31 : local_double);
        Sum += (lb_true ^ lb_false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_87()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ lb_false ? -5.31 : simple_func_double());
        Sum += (lb_true ^ lb_false ? -5.31 : ab[index]);
        Sum += (lb_true ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ lb_false ? local_double : 3.1);
        Sum += (lb_true ^ lb_false ? local_double : -5.31);
        Sum += (lb_true ^ lb_false ? local_double : local_double);
        Sum += (lb_true ^ lb_false ? local_double : static_field_double);
        Sum += (lb_true ^ lb_false ? local_double : t1_i.mfd);
        Sum += (lb_true ^ lb_false ? local_double : simple_func_double());
        Sum += (lb_true ^ lb_false ? local_double : ab[index]);
        Sum += (lb_true ^ lb_false ? local_double : ab[index - 1]);
        Sum += (lb_true ^ lb_false ? static_field_double : 3.1);
        Sum += (lb_true ^ lb_false ? static_field_double : -5.31);
        Sum += (lb_true ^ lb_false ? static_field_double : local_double);
        Sum += (lb_true ^ lb_false ? static_field_double : static_field_double);
        Sum += (lb_true ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ lb_false ? static_field_double : simple_func_double());
        Sum += (lb_true ^ lb_false ? static_field_double : ab[index]);
        Sum += (lb_true ^ lb_false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_88()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ lb_false ? t1_i.mfd : local_double);
        Sum += (lb_true ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ lb_false ? simple_func_double() : 3.1);
        Sum += (lb_true ^ lb_false ? simple_func_double() : -5.31);
        Sum += (lb_true ^ lb_false ? simple_func_double() : local_double);
        Sum += (lb_true ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ lb_false ? ab[index] : 3.1);
        Sum += (lb_true ^ lb_false ? ab[index] : -5.31);
        Sum += (lb_true ^ lb_false ? ab[index] : local_double);
        Sum += (lb_true ^ lb_false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_89()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ lb_false ? ab[index] : simple_func_double());
        Sum += (lb_true ^ lb_false ? ab[index] : ab[index]);
        Sum += (lb_true ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ lb_false ? ab[index - 1] : local_double);
        Sum += (lb_true ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ sfb_true ? 3.1 : 3.1);
        Sum += (lb_true ^ sfb_true ? 3.1 : -5.31);
        Sum += (lb_true ^ sfb_true ? 3.1 : local_double);
        Sum += (lb_true ^ sfb_true ? 3.1 : static_field_double);
        Sum += (lb_true ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (lb_true ^ sfb_true ? 3.1 : ab[index]);
        Sum += (lb_true ^ sfb_true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_90()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ sfb_true ? -5.31 : 3.1);
        Sum += (lb_true ^ sfb_true ? -5.31 : -5.31);
        Sum += (lb_true ^ sfb_true ? -5.31 : local_double);
        Sum += (lb_true ^ sfb_true ? -5.31 : static_field_double);
        Sum += (lb_true ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (lb_true ^ sfb_true ? -5.31 : ab[index]);
        Sum += (lb_true ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ sfb_true ? local_double : 3.1);
        Sum += (lb_true ^ sfb_true ? local_double : -5.31);
        Sum += (lb_true ^ sfb_true ? local_double : local_double);
        Sum += (lb_true ^ sfb_true ? local_double : static_field_double);
        Sum += (lb_true ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (lb_true ^ sfb_true ? local_double : simple_func_double());
        Sum += (lb_true ^ sfb_true ? local_double : ab[index]);
        Sum += (lb_true ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (lb_true ^ sfb_true ? static_field_double : 3.1);
        Sum += (lb_true ^ sfb_true ? static_field_double : -5.31);
        Sum += (lb_true ^ sfb_true ? static_field_double : local_double);
        Sum += (lb_true ^ sfb_true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_91()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (lb_true ^ sfb_true ? static_field_double : ab[index]);
        Sum += (lb_true ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (lb_true ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (lb_true ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (lb_true ^ sfb_true ? simple_func_double() : local_double);
        Sum += (lb_true ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ sfb_true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_92()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ sfb_true ? ab[index] : 3.1);
        Sum += (lb_true ^ sfb_true ? ab[index] : -5.31);
        Sum += (lb_true ^ sfb_true ? ab[index] : local_double);
        Sum += (lb_true ^ sfb_true ? ab[index] : static_field_double);
        Sum += (lb_true ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (lb_true ^ sfb_true ? ab[index] : ab[index]);
        Sum += (lb_true ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (lb_true ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ sfb_false ? 3.1 : 3.1);
        Sum += (lb_true ^ sfb_false ? 3.1 : -5.31);
        Sum += (lb_true ^ sfb_false ? 3.1 : local_double);
        Sum += (lb_true ^ sfb_false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_93()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (lb_true ^ sfb_false ? 3.1 : ab[index]);
        Sum += (lb_true ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ sfb_false ? -5.31 : 3.1);
        Sum += (lb_true ^ sfb_false ? -5.31 : -5.31);
        Sum += (lb_true ^ sfb_false ? -5.31 : local_double);
        Sum += (lb_true ^ sfb_false ? -5.31 : static_field_double);
        Sum += (lb_true ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (lb_true ^ sfb_false ? -5.31 : ab[index]);
        Sum += (lb_true ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ sfb_false ? local_double : 3.1);
        Sum += (lb_true ^ sfb_false ? local_double : -5.31);
        Sum += (lb_true ^ sfb_false ? local_double : local_double);
        Sum += (lb_true ^ sfb_false ? local_double : static_field_double);
        Sum += (lb_true ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (lb_true ^ sfb_false ? local_double : simple_func_double());
        Sum += (lb_true ^ sfb_false ? local_double : ab[index]);
        Sum += (lb_true ^ sfb_false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_94()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ sfb_false ? static_field_double : 3.1);
        Sum += (lb_true ^ sfb_false ? static_field_double : -5.31);
        Sum += (lb_true ^ sfb_false ? static_field_double : local_double);
        Sum += (lb_true ^ sfb_false ? static_field_double : static_field_double);
        Sum += (lb_true ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (lb_true ^ sfb_false ? static_field_double : ab[index]);
        Sum += (lb_true ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (lb_true ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (lb_true ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (lb_true ^ sfb_false ? simple_func_double() : local_double);
        Sum += (lb_true ^ sfb_false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_95()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ sfb_false ? ab[index] : 3.1);
        Sum += (lb_true ^ sfb_false ? ab[index] : -5.31);
        Sum += (lb_true ^ sfb_false ? ab[index] : local_double);
        Sum += (lb_true ^ sfb_false ? ab[index] : static_field_double);
        Sum += (lb_true ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (lb_true ^ sfb_false ? ab[index] : ab[index]);
        Sum += (lb_true ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (lb_true ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_96()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (lb_true ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (lb_true ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (lb_true ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (lb_true ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (lb_true ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (lb_true ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (lb_true ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (lb_true ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (lb_true ^ t1_i.mfb_true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_97()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (lb_true ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (lb_true ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (lb_true ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (lb_true ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_98()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (lb_true ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (lb_true ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (lb_true ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_99()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (lb_true ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (lb_true ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (lb_true ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (lb_true ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (lb_true ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (lb_true ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_100()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (lb_true ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (lb_true ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (lb_true ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (lb_true ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (lb_true ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (lb_true ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (lb_true ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_101()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (lb_true ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (lb_true ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (lb_true ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_102()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (lb_true ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (lb_true ^ func_sb_true() ? 3.1 : local_double);
        Sum += (lb_true ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (lb_true ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (lb_true ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (lb_true ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (lb_true ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (lb_true ^ func_sb_true() ? -5.31 : local_double);
        Sum += (lb_true ^ func_sb_true() ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_103()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (lb_true ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (lb_true ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ func_sb_true() ? local_double : 3.1);
        Sum += (lb_true ^ func_sb_true() ? local_double : -5.31);
        Sum += (lb_true ^ func_sb_true() ? local_double : local_double);
        Sum += (lb_true ^ func_sb_true() ? local_double : static_field_double);
        Sum += (lb_true ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (lb_true ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (lb_true ^ func_sb_true() ? local_double : ab[index]);
        Sum += (lb_true ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (lb_true ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (lb_true ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (lb_true ^ func_sb_true() ? static_field_double : local_double);
        Sum += (lb_true ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (lb_true ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (lb_true ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (lb_true ^ func_sb_true() ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_104()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (lb_true ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (lb_true ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (lb_true ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (lb_true ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (lb_true ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (lb_true ^ func_sb_true() ? ab[index] : local_double);
        Sum += (lb_true ^ func_sb_true() ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_105()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (lb_true ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (lb_true ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (lb_true ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (lb_true ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (lb_true ^ func_sb_false() ? 3.1 : local_double);
        Sum += (lb_true ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (lb_true ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (lb_true ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (lb_true ^ func_sb_false() ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_106()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (lb_true ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (lb_true ^ func_sb_false() ? -5.31 : local_double);
        Sum += (lb_true ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (lb_true ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (lb_true ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (lb_true ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ func_sb_false() ? local_double : 3.1);
        Sum += (lb_true ^ func_sb_false() ? local_double : -5.31);
        Sum += (lb_true ^ func_sb_false() ? local_double : local_double);
        Sum += (lb_true ^ func_sb_false() ? local_double : static_field_double);
        Sum += (lb_true ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (lb_true ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (lb_true ^ func_sb_false() ? local_double : ab[index]);
        Sum += (lb_true ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (lb_true ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (lb_true ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (lb_true ^ func_sb_false() ? static_field_double : local_double);
        Sum += (lb_true ^ func_sb_false() ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_107()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (lb_true ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (lb_true ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (lb_true ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (lb_true ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (lb_true ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (lb_true ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_108()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (lb_true ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (lb_true ^ func_sb_false() ? ab[index] : local_double);
        Sum += (lb_true ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (lb_true ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (lb_true ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (lb_true ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (lb_true ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_true ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (lb_true ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (lb_true ^ ab_true[index] ? 3.1 : local_double);
        Sum += (lb_true ^ ab_true[index] ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_109()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (lb_true ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (lb_true ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (lb_true ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (lb_true ^ ab_true[index] ? -5.31 : local_double);
        Sum += (lb_true ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (lb_true ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (lb_true ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (lb_true ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ ab_true[index] ? local_double : 3.1);
        Sum += (lb_true ^ ab_true[index] ? local_double : -5.31);
        Sum += (lb_true ^ ab_true[index] ? local_double : local_double);
        Sum += (lb_true ^ ab_true[index] ? local_double : static_field_double);
        Sum += (lb_true ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (lb_true ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (lb_true ^ ab_true[index] ? local_double : ab[index]);
        Sum += (lb_true ^ ab_true[index] ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_110()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (lb_true ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (lb_true ^ ab_true[index] ? static_field_double : local_double);
        Sum += (lb_true ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (lb_true ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (lb_true ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (lb_true ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (lb_true ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_true ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (lb_true ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (lb_true ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (lb_true ^ ab_true[index] ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_111()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (lb_true ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (lb_true ^ ab_true[index] ? ab[index] : local_double);
        Sum += (lb_true ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (lb_true ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (lb_true ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (lb_true ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (lb_true ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (lb_true ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_112()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (lb_true ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (lb_true ^ ab_false[index] ? 3.1 : local_double);
        Sum += (lb_true ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (lb_true ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (lb_true ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (lb_true ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (lb_true ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (lb_true ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (lb_true ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (lb_true ^ ab_false[index] ? -5.31 : local_double);
        Sum += (lb_true ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (lb_true ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (lb_true ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (lb_true ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (lb_true ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (lb_true ^ ab_false[index] ? local_double : 3.1);
        Sum += (lb_true ^ ab_false[index] ? local_double : -5.31);
        Sum += (lb_true ^ ab_false[index] ? local_double : local_double);
        Sum += (lb_true ^ ab_false[index] ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_113()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (lb_true ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (lb_true ^ ab_false[index] ? local_double : ab[index]);
        Sum += (lb_true ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (lb_true ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (lb_true ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (lb_true ^ ab_false[index] ? static_field_double : local_double);
        Sum += (lb_true ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (lb_true ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (lb_true ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (lb_true ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (lb_true ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (lb_true ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (lb_true ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (lb_true ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (lb_true ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (lb_true ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_true ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (lb_true ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (lb_true ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_114()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (lb_true ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (lb_true ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (lb_true ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (lb_true ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (lb_true ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (lb_true ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (lb_true ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (lb_true ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (lb_true ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (lb_true ^ ab_false[index] ? ab[index] : local_double);
        Sum += (lb_true ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (lb_true ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (lb_true ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (lb_true ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (lb_true ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (lb_true ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (lb_true ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (lb_true ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (lb_true ^ ab_false[index] ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_115()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_true ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_true ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (lb_true ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (lb_true ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ true ? 3.1 : 3.1);
        Sum += (lb_false ^ true ? 3.1 : -5.31);
        Sum += (lb_false ^ true ? 3.1 : local_double);
        Sum += (lb_false ^ true ? 3.1 : static_field_double);
        Sum += (lb_false ^ true ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ true ? 3.1 : simple_func_double());
        Sum += (lb_false ^ true ? 3.1 : ab[index]);
        Sum += (lb_false ^ true ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ true ? -5.31 : 3.1);
        Sum += (lb_false ^ true ? -5.31 : -5.31);
        Sum += (lb_false ^ true ? -5.31 : local_double);
        Sum += (lb_false ^ true ? -5.31 : static_field_double);
        Sum += (lb_false ^ true ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ true ? -5.31 : simple_func_double());
        Sum += (lb_false ^ true ? -5.31 : ab[index]);
        Sum += (lb_false ^ true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_116()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ true ? local_double : 3.1);
        Sum += (lb_false ^ true ? local_double : -5.31);
        Sum += (lb_false ^ true ? local_double : local_double);
        Sum += (lb_false ^ true ? local_double : static_field_double);
        Sum += (lb_false ^ true ? local_double : t1_i.mfd);
        Sum += (lb_false ^ true ? local_double : simple_func_double());
        Sum += (lb_false ^ true ? local_double : ab[index]);
        Sum += (lb_false ^ true ? local_double : ab[index - 1]);
        Sum += (lb_false ^ true ? static_field_double : 3.1);
        Sum += (lb_false ^ true ? static_field_double : -5.31);
        Sum += (lb_false ^ true ? static_field_double : local_double);
        Sum += (lb_false ^ true ? static_field_double : static_field_double);
        Sum += (lb_false ^ true ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ true ? static_field_double : simple_func_double());
        Sum += (lb_false ^ true ? static_field_double : ab[index]);
        Sum += (lb_false ^ true ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ true ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ true ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ true ? t1_i.mfd : local_double);
        Sum += (lb_false ^ true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_117()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ true ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ true ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ true ? simple_func_double() : 3.1);
        Sum += (lb_false ^ true ? simple_func_double() : -5.31);
        Sum += (lb_false ^ true ? simple_func_double() : local_double);
        Sum += (lb_false ^ true ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ true ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ true ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ true ? ab[index] : 3.1);
        Sum += (lb_false ^ true ? ab[index] : -5.31);
        Sum += (lb_false ^ true ? ab[index] : local_double);
        Sum += (lb_false ^ true ? ab[index] : static_field_double);
        Sum += (lb_false ^ true ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ true ? ab[index] : simple_func_double());
        Sum += (lb_false ^ true ? ab[index] : ab[index]);
        Sum += (lb_false ^ true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_118()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ true ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ true ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ true ? ab[index - 1] : local_double);
        Sum += (lb_false ^ true ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ true ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ true ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ false ? 3.1 : 3.1);
        Sum += (lb_false ^ false ? 3.1 : -5.31);
        Sum += (lb_false ^ false ? 3.1 : local_double);
        Sum += (lb_false ^ false ? 3.1 : static_field_double);
        Sum += (lb_false ^ false ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ false ? 3.1 : simple_func_double());
        Sum += (lb_false ^ false ? 3.1 : ab[index]);
        Sum += (lb_false ^ false ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ false ? -5.31 : 3.1);
        Sum += (lb_false ^ false ? -5.31 : -5.31);
        Sum += (lb_false ^ false ? -5.31 : local_double);
        Sum += (lb_false ^ false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_119()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ false ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ false ? -5.31 : simple_func_double());
        Sum += (lb_false ^ false ? -5.31 : ab[index]);
        Sum += (lb_false ^ false ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ false ? local_double : 3.1);
        Sum += (lb_false ^ false ? local_double : -5.31);
        Sum += (lb_false ^ false ? local_double : local_double);
        Sum += (lb_false ^ false ? local_double : static_field_double);
        Sum += (lb_false ^ false ? local_double : t1_i.mfd);
        Sum += (lb_false ^ false ? local_double : simple_func_double());
        Sum += (lb_false ^ false ? local_double : ab[index]);
        Sum += (lb_false ^ false ? local_double : ab[index - 1]);
        Sum += (lb_false ^ false ? static_field_double : 3.1);
        Sum += (lb_false ^ false ? static_field_double : -5.31);
        Sum += (lb_false ^ false ? static_field_double : local_double);
        Sum += (lb_false ^ false ? static_field_double : static_field_double);
        Sum += (lb_false ^ false ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ false ? static_field_double : simple_func_double());
        Sum += (lb_false ^ false ? static_field_double : ab[index]);
        Sum += (lb_false ^ false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_120()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ false ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ false ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ false ? t1_i.mfd : local_double);
        Sum += (lb_false ^ false ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ false ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ false ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ false ? simple_func_double() : 3.1);
        Sum += (lb_false ^ false ? simple_func_double() : -5.31);
        Sum += (lb_false ^ false ? simple_func_double() : local_double);
        Sum += (lb_false ^ false ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ false ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ false ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ false ? ab[index] : 3.1);
        Sum += (lb_false ^ false ? ab[index] : -5.31);
        Sum += (lb_false ^ false ? ab[index] : local_double);
        Sum += (lb_false ^ false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_121()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ false ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ false ? ab[index] : simple_func_double());
        Sum += (lb_false ^ false ? ab[index] : ab[index]);
        Sum += (lb_false ^ false ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ false ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ false ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ false ? ab[index - 1] : local_double);
        Sum += (lb_false ^ false ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ false ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ false ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ lb_true ? 3.1 : 3.1);
        Sum += (lb_false ^ lb_true ? 3.1 : -5.31);
        Sum += (lb_false ^ lb_true ? 3.1 : local_double);
        Sum += (lb_false ^ lb_true ? 3.1 : static_field_double);
        Sum += (lb_false ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ lb_true ? 3.1 : simple_func_double());
        Sum += (lb_false ^ lb_true ? 3.1 : ab[index]);
        Sum += (lb_false ^ lb_true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_122()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ lb_true ? -5.31 : 3.1);
        Sum += (lb_false ^ lb_true ? -5.31 : -5.31);
        Sum += (lb_false ^ lb_true ? -5.31 : local_double);
        Sum += (lb_false ^ lb_true ? -5.31 : static_field_double);
        Sum += (lb_false ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ lb_true ? -5.31 : simple_func_double());
        Sum += (lb_false ^ lb_true ? -5.31 : ab[index]);
        Sum += (lb_false ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ lb_true ? local_double : 3.1);
        Sum += (lb_false ^ lb_true ? local_double : -5.31);
        Sum += (lb_false ^ lb_true ? local_double : local_double);
        Sum += (lb_false ^ lb_true ? local_double : static_field_double);
        Sum += (lb_false ^ lb_true ? local_double : t1_i.mfd);
        Sum += (lb_false ^ lb_true ? local_double : simple_func_double());
        Sum += (lb_false ^ lb_true ? local_double : ab[index]);
        Sum += (lb_false ^ lb_true ? local_double : ab[index - 1]);
        Sum += (lb_false ^ lb_true ? static_field_double : 3.1);
        Sum += (lb_false ^ lb_true ? static_field_double : -5.31);
        Sum += (lb_false ^ lb_true ? static_field_double : local_double);
        Sum += (lb_false ^ lb_true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_123()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ lb_true ? static_field_double : simple_func_double());
        Sum += (lb_false ^ lb_true ? static_field_double : ab[index]);
        Sum += (lb_false ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ lb_true ? t1_i.mfd : local_double);
        Sum += (lb_false ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ lb_true ? simple_func_double() : 3.1);
        Sum += (lb_false ^ lb_true ? simple_func_double() : -5.31);
        Sum += (lb_false ^ lb_true ? simple_func_double() : local_double);
        Sum += (lb_false ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ lb_true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_124()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ lb_true ? ab[index] : 3.1);
        Sum += (lb_false ^ lb_true ? ab[index] : -5.31);
        Sum += (lb_false ^ lb_true ? ab[index] : local_double);
        Sum += (lb_false ^ lb_true ? ab[index] : static_field_double);
        Sum += (lb_false ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ lb_true ? ab[index] : simple_func_double());
        Sum += (lb_false ^ lb_true ? ab[index] : ab[index]);
        Sum += (lb_false ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ lb_true ? ab[index - 1] : local_double);
        Sum += (lb_false ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ lb_false ? 3.1 : 3.1);
        Sum += (lb_false ^ lb_false ? 3.1 : -5.31);
        Sum += (lb_false ^ lb_false ? 3.1 : local_double);
        Sum += (lb_false ^ lb_false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_125()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ lb_false ? 3.1 : simple_func_double());
        Sum += (lb_false ^ lb_false ? 3.1 : ab[index]);
        Sum += (lb_false ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ lb_false ? -5.31 : 3.1);
        Sum += (lb_false ^ lb_false ? -5.31 : -5.31);
        Sum += (lb_false ^ lb_false ? -5.31 : local_double);
        Sum += (lb_false ^ lb_false ? -5.31 : static_field_double);
        Sum += (lb_false ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ lb_false ? -5.31 : simple_func_double());
        Sum += (lb_false ^ lb_false ? -5.31 : ab[index]);
        Sum += (lb_false ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ lb_false ? local_double : 3.1);
        Sum += (lb_false ^ lb_false ? local_double : -5.31);
        Sum += (lb_false ^ lb_false ? local_double : local_double);
        Sum += (lb_false ^ lb_false ? local_double : static_field_double);
        Sum += (lb_false ^ lb_false ? local_double : t1_i.mfd);
        Sum += (lb_false ^ lb_false ? local_double : simple_func_double());
        Sum += (lb_false ^ lb_false ? local_double : ab[index]);
        Sum += (lb_false ^ lb_false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_126()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ lb_false ? static_field_double : 3.1);
        Sum += (lb_false ^ lb_false ? static_field_double : -5.31);
        Sum += (lb_false ^ lb_false ? static_field_double : local_double);
        Sum += (lb_false ^ lb_false ? static_field_double : static_field_double);
        Sum += (lb_false ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ lb_false ? static_field_double : simple_func_double());
        Sum += (lb_false ^ lb_false ? static_field_double : ab[index]);
        Sum += (lb_false ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ lb_false ? t1_i.mfd : local_double);
        Sum += (lb_false ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ lb_false ? simple_func_double() : 3.1);
        Sum += (lb_false ^ lb_false ? simple_func_double() : -5.31);
        Sum += (lb_false ^ lb_false ? simple_func_double() : local_double);
        Sum += (lb_false ^ lb_false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_127()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ lb_false ? ab[index] : 3.1);
        Sum += (lb_false ^ lb_false ? ab[index] : -5.31);
        Sum += (lb_false ^ lb_false ? ab[index] : local_double);
        Sum += (lb_false ^ lb_false ? ab[index] : static_field_double);
        Sum += (lb_false ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ lb_false ? ab[index] : simple_func_double());
        Sum += (lb_false ^ lb_false ? ab[index] : ab[index]);
        Sum += (lb_false ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ lb_false ? ab[index - 1] : local_double);
        Sum += (lb_false ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ lb_false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_128()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ sfb_true ? 3.1 : 3.1);
        Sum += (lb_false ^ sfb_true ? 3.1 : -5.31);
        Sum += (lb_false ^ sfb_true ? 3.1 : local_double);
        Sum += (lb_false ^ sfb_true ? 3.1 : static_field_double);
        Sum += (lb_false ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (lb_false ^ sfb_true ? 3.1 : ab[index]);
        Sum += (lb_false ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ sfb_true ? -5.31 : 3.1);
        Sum += (lb_false ^ sfb_true ? -5.31 : -5.31);
        Sum += (lb_false ^ sfb_true ? -5.31 : local_double);
        Sum += (lb_false ^ sfb_true ? -5.31 : static_field_double);
        Sum += (lb_false ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (lb_false ^ sfb_true ? -5.31 : ab[index]);
        Sum += (lb_false ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ sfb_true ? local_double : 3.1);
        Sum += (lb_false ^ sfb_true ? local_double : -5.31);
        Sum += (lb_false ^ sfb_true ? local_double : local_double);
        Sum += (lb_false ^ sfb_true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_129()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (lb_false ^ sfb_true ? local_double : simple_func_double());
        Sum += (lb_false ^ sfb_true ? local_double : ab[index]);
        Sum += (lb_false ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (lb_false ^ sfb_true ? static_field_double : 3.1);
        Sum += (lb_false ^ sfb_true ? static_field_double : -5.31);
        Sum += (lb_false ^ sfb_true ? static_field_double : local_double);
        Sum += (lb_false ^ sfb_true ? static_field_double : static_field_double);
        Sum += (lb_false ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (lb_false ^ sfb_true ? static_field_double : ab[index]);
        Sum += (lb_false ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (lb_false ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_130()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (lb_false ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (lb_false ^ sfb_true ? simple_func_double() : local_double);
        Sum += (lb_false ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ sfb_true ? ab[index] : 3.1);
        Sum += (lb_false ^ sfb_true ? ab[index] : -5.31);
        Sum += (lb_false ^ sfb_true ? ab[index] : local_double);
        Sum += (lb_false ^ sfb_true ? ab[index] : static_field_double);
        Sum += (lb_false ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (lb_false ^ sfb_true ? ab[index] : ab[index]);
        Sum += (lb_false ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (lb_false ^ sfb_true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_131()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ sfb_false ? 3.1 : 3.1);
        Sum += (lb_false ^ sfb_false ? 3.1 : -5.31);
        Sum += (lb_false ^ sfb_false ? 3.1 : local_double);
        Sum += (lb_false ^ sfb_false ? 3.1 : static_field_double);
        Sum += (lb_false ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (lb_false ^ sfb_false ? 3.1 : ab[index]);
        Sum += (lb_false ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ sfb_false ? -5.31 : 3.1);
        Sum += (lb_false ^ sfb_false ? -5.31 : -5.31);
        Sum += (lb_false ^ sfb_false ? -5.31 : local_double);
        Sum += (lb_false ^ sfb_false ? -5.31 : static_field_double);
        Sum += (lb_false ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (lb_false ^ sfb_false ? -5.31 : ab[index]);
        Sum += (lb_false ^ sfb_false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_132()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ sfb_false ? local_double : 3.1);
        Sum += (lb_false ^ sfb_false ? local_double : -5.31);
        Sum += (lb_false ^ sfb_false ? local_double : local_double);
        Sum += (lb_false ^ sfb_false ? local_double : static_field_double);
        Sum += (lb_false ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (lb_false ^ sfb_false ? local_double : simple_func_double());
        Sum += (lb_false ^ sfb_false ? local_double : ab[index]);
        Sum += (lb_false ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (lb_false ^ sfb_false ? static_field_double : 3.1);
        Sum += (lb_false ^ sfb_false ? static_field_double : -5.31);
        Sum += (lb_false ^ sfb_false ? static_field_double : local_double);
        Sum += (lb_false ^ sfb_false ? static_field_double : static_field_double);
        Sum += (lb_false ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (lb_false ^ sfb_false ? static_field_double : ab[index]);
        Sum += (lb_false ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (lb_false ^ sfb_false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_133()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (lb_false ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (lb_false ^ sfb_false ? simple_func_double() : local_double);
        Sum += (lb_false ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ sfb_false ? ab[index] : 3.1);
        Sum += (lb_false ^ sfb_false ? ab[index] : -5.31);
        Sum += (lb_false ^ sfb_false ? ab[index] : local_double);
        Sum += (lb_false ^ sfb_false ? ab[index] : static_field_double);
        Sum += (lb_false ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (lb_false ^ sfb_false ? ab[index] : ab[index]);
        Sum += (lb_false ^ sfb_false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_134()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (lb_false ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (lb_false ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (lb_false ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (lb_false ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (lb_false ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (lb_false ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (lb_false ^ t1_i.mfb_true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_135()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (lb_false ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (lb_false ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (lb_false ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (lb_false ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (lb_false ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (lb_false ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_136()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (lb_false ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (lb_false ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (lb_false ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (lb_false ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_137()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (lb_false ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (lb_false ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (lb_false ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_138()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (lb_false ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (lb_false ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (lb_false ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (lb_false ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (lb_false ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (lb_false ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (lb_false ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (lb_false ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (lb_false ^ t1_i.mfb_false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_139()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (lb_false ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (lb_false ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (lb_false ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (lb_false ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_140()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (lb_false ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (lb_false ^ func_sb_true() ? 3.1 : local_double);
        Sum += (lb_false ^ func_sb_true() ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_141()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (lb_false ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (lb_false ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (lb_false ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (lb_false ^ func_sb_true() ? -5.31 : local_double);
        Sum += (lb_false ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (lb_false ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (lb_false ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (lb_false ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ func_sb_true() ? local_double : 3.1);
        Sum += (lb_false ^ func_sb_true() ? local_double : -5.31);
        Sum += (lb_false ^ func_sb_true() ? local_double : local_double);
        Sum += (lb_false ^ func_sb_true() ? local_double : static_field_double);
        Sum += (lb_false ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (lb_false ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (lb_false ^ func_sb_true() ? local_double : ab[index]);
        Sum += (lb_false ^ func_sb_true() ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_142()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (lb_false ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (lb_false ^ func_sb_true() ? static_field_double : local_double);
        Sum += (lb_false ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (lb_false ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (lb_false ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (lb_false ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (lb_false ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (lb_false ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (lb_false ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (lb_false ^ func_sb_true() ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_143()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (lb_false ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (lb_false ^ func_sb_true() ? ab[index] : local_double);
        Sum += (lb_false ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (lb_false ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (lb_false ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (lb_false ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (lb_false ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_144()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (lb_false ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (lb_false ^ func_sb_false() ? 3.1 : local_double);
        Sum += (lb_false ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (lb_false ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (lb_false ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (lb_false ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (lb_false ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (lb_false ^ func_sb_false() ? -5.31 : local_double);
        Sum += (lb_false ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (lb_false ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (lb_false ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (lb_false ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ func_sb_false() ? local_double : 3.1);
        Sum += (lb_false ^ func_sb_false() ? local_double : -5.31);
        Sum += (lb_false ^ func_sb_false() ? local_double : local_double);
        Sum += (lb_false ^ func_sb_false() ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_145()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (lb_false ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (lb_false ^ func_sb_false() ? local_double : ab[index]);
        Sum += (lb_false ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (lb_false ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (lb_false ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (lb_false ^ func_sb_false() ? static_field_double : local_double);
        Sum += (lb_false ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (lb_false ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (lb_false ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (lb_false ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (lb_false ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_146()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (lb_false ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (lb_false ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (lb_false ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (lb_false ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (lb_false ^ func_sb_false() ? ab[index] : local_double);
        Sum += (lb_false ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (lb_false ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (lb_false ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (lb_false ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (lb_false ^ func_sb_false() ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_147()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (lb_false ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (lb_false ^ ab_true[index] ? 3.1 : local_double);
        Sum += (lb_false ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (lb_false ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (lb_false ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (lb_false ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (lb_false ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (lb_false ^ ab_true[index] ? -5.31 : local_double);
        Sum += (lb_false ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (lb_false ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (lb_false ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (lb_false ^ ab_true[index] ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_148()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ ab_true[index] ? local_double : 3.1);
        Sum += (lb_false ^ ab_true[index] ? local_double : -5.31);
        Sum += (lb_false ^ ab_true[index] ? local_double : local_double);
        Sum += (lb_false ^ ab_true[index] ? local_double : static_field_double);
        Sum += (lb_false ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (lb_false ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (lb_false ^ ab_true[index] ? local_double : ab[index]);
        Sum += (lb_false ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (lb_false ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (lb_false ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (lb_false ^ ab_true[index] ? static_field_double : local_double);
        Sum += (lb_false ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (lb_false ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (lb_false ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (lb_false ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (lb_false ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (lb_false ^ ab_true[index] ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_149()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (lb_false ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (lb_false ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (lb_false ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (lb_false ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (lb_false ^ ab_true[index] ? ab[index] : local_double);
        Sum += (lb_false ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (lb_false ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (lb_false ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (lb_false ^ ab_true[index] ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_150()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (lb_false ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (lb_false ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (lb_false ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (lb_false ^ ab_false[index] ? 3.1 : local_double);
        Sum += (lb_false ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (lb_false ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (lb_false ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (lb_false ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (lb_false ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (lb_false ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (lb_false ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (lb_false ^ ab_false[index] ? -5.31 : local_double);
        Sum += (lb_false ^ ab_false[index] ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_151()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (lb_false ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (lb_false ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (lb_false ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (lb_false ^ ab_false[index] ? local_double : 3.1);
        Sum += (lb_false ^ ab_false[index] ? local_double : -5.31);
        Sum += (lb_false ^ ab_false[index] ? local_double : local_double);
        Sum += (lb_false ^ ab_false[index] ? local_double : static_field_double);
        Sum += (lb_false ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (lb_false ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (lb_false ^ ab_false[index] ? local_double : ab[index]);
        Sum += (lb_false ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (lb_false ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (lb_false ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (lb_false ^ ab_false[index] ? static_field_double : local_double);
        Sum += (lb_false ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (lb_false ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (lb_false ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (lb_false ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (lb_false ^ ab_false[index] ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_152()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (lb_false ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (lb_false ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (lb_false ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (lb_false ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (lb_false ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (lb_false ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (lb_false ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (lb_false ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (lb_false ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (lb_false ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (lb_false ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (lb_false ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (lb_false ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (lb_false ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (lb_false ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (lb_false ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (lb_false ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (lb_false ^ ab_false[index] ? ab[index] : local_double);
        Sum += (lb_false ^ ab_false[index] ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_153()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (lb_false ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (lb_false ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (lb_false ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (lb_false ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (lb_false ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (lb_false ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (lb_false ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (lb_false ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (lb_false ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (lb_false ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (lb_false ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (lb_false ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ true ? 3.1 : 3.1);
        Sum += (sfb_true ^ true ? 3.1 : -5.31);
        Sum += (sfb_true ^ true ? 3.1 : local_double);
        Sum += (sfb_true ^ true ? 3.1 : static_field_double);
        Sum += (sfb_true ^ true ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ true ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ true ? 3.1 : ab[index]);
        Sum += (sfb_true ^ true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_154()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ true ? -5.31 : 3.1);
        Sum += (sfb_true ^ true ? -5.31 : -5.31);
        Sum += (sfb_true ^ true ? -5.31 : local_double);
        Sum += (sfb_true ^ true ? -5.31 : static_field_double);
        Sum += (sfb_true ^ true ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ true ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ true ? -5.31 : ab[index]);
        Sum += (sfb_true ^ true ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ true ? local_double : 3.1);
        Sum += (sfb_true ^ true ? local_double : -5.31);
        Sum += (sfb_true ^ true ? local_double : local_double);
        Sum += (sfb_true ^ true ? local_double : static_field_double);
        Sum += (sfb_true ^ true ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ true ? local_double : simple_func_double());
        Sum += (sfb_true ^ true ? local_double : ab[index]);
        Sum += (sfb_true ^ true ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ true ? static_field_double : 3.1);
        Sum += (sfb_true ^ true ? static_field_double : -5.31);
        Sum += (sfb_true ^ true ? static_field_double : local_double);
        Sum += (sfb_true ^ true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_155()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ true ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ true ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ true ? static_field_double : ab[index]);
        Sum += (sfb_true ^ true ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ true ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ true ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ true ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ true ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ true ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ true ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ true ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ true ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ true ? simple_func_double() : local_double);
        Sum += (sfb_true ^ true ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ true ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ true ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_156()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ true ? ab[index] : 3.1);
        Sum += (sfb_true ^ true ? ab[index] : -5.31);
        Sum += (sfb_true ^ true ? ab[index] : local_double);
        Sum += (sfb_true ^ true ? ab[index] : static_field_double);
        Sum += (sfb_true ^ true ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ true ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ true ? ab[index] : ab[index]);
        Sum += (sfb_true ^ true ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ true ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ true ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ true ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ true ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ true ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ true ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ false ? 3.1 : 3.1);
        Sum += (sfb_true ^ false ? 3.1 : -5.31);
        Sum += (sfb_true ^ false ? 3.1 : local_double);
        Sum += (sfb_true ^ false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_157()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ false ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ false ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ false ? 3.1 : ab[index]);
        Sum += (sfb_true ^ false ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ false ? -5.31 : 3.1);
        Sum += (sfb_true ^ false ? -5.31 : -5.31);
        Sum += (sfb_true ^ false ? -5.31 : local_double);
        Sum += (sfb_true ^ false ? -5.31 : static_field_double);
        Sum += (sfb_true ^ false ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ false ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ false ? -5.31 : ab[index]);
        Sum += (sfb_true ^ false ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ false ? local_double : 3.1);
        Sum += (sfb_true ^ false ? local_double : -5.31);
        Sum += (sfb_true ^ false ? local_double : local_double);
        Sum += (sfb_true ^ false ? local_double : static_field_double);
        Sum += (sfb_true ^ false ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ false ? local_double : simple_func_double());
        Sum += (sfb_true ^ false ? local_double : ab[index]);
        Sum += (sfb_true ^ false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_158()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ false ? static_field_double : 3.1);
        Sum += (sfb_true ^ false ? static_field_double : -5.31);
        Sum += (sfb_true ^ false ? static_field_double : local_double);
        Sum += (sfb_true ^ false ? static_field_double : static_field_double);
        Sum += (sfb_true ^ false ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ false ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ false ? static_field_double : ab[index]);
        Sum += (sfb_true ^ false ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ false ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ false ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ false ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ false ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ false ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ false ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ false ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ false ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ false ? simple_func_double() : local_double);
        Sum += (sfb_true ^ false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_159()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ false ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ false ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ false ? ab[index] : 3.1);
        Sum += (sfb_true ^ false ? ab[index] : -5.31);
        Sum += (sfb_true ^ false ? ab[index] : local_double);
        Sum += (sfb_true ^ false ? ab[index] : static_field_double);
        Sum += (sfb_true ^ false ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ false ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ false ? ab[index] : ab[index]);
        Sum += (sfb_true ^ false ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ false ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ false ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ false ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ false ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ false ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ false ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_160()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ lb_true ? 3.1 : 3.1);
        Sum += (sfb_true ^ lb_true ? 3.1 : -5.31);
        Sum += (sfb_true ^ lb_true ? 3.1 : local_double);
        Sum += (sfb_true ^ lb_true ? 3.1 : static_field_double);
        Sum += (sfb_true ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ lb_true ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ lb_true ? 3.1 : ab[index]);
        Sum += (sfb_true ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ lb_true ? -5.31 : 3.1);
        Sum += (sfb_true ^ lb_true ? -5.31 : -5.31);
        Sum += (sfb_true ^ lb_true ? -5.31 : local_double);
        Sum += (sfb_true ^ lb_true ? -5.31 : static_field_double);
        Sum += (sfb_true ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ lb_true ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ lb_true ? -5.31 : ab[index]);
        Sum += (sfb_true ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ lb_true ? local_double : 3.1);
        Sum += (sfb_true ^ lb_true ? local_double : -5.31);
        Sum += (sfb_true ^ lb_true ? local_double : local_double);
        Sum += (sfb_true ^ lb_true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_161()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ lb_true ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ lb_true ? local_double : simple_func_double());
        Sum += (sfb_true ^ lb_true ? local_double : ab[index]);
        Sum += (sfb_true ^ lb_true ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ lb_true ? static_field_double : 3.1);
        Sum += (sfb_true ^ lb_true ? static_field_double : -5.31);
        Sum += (sfb_true ^ lb_true ? static_field_double : local_double);
        Sum += (sfb_true ^ lb_true ? static_field_double : static_field_double);
        Sum += (sfb_true ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ lb_true ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ lb_true ? static_field_double : ab[index]);
        Sum += (sfb_true ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ lb_true ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ lb_true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_162()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ lb_true ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ lb_true ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ lb_true ? simple_func_double() : local_double);
        Sum += (sfb_true ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ lb_true ? ab[index] : 3.1);
        Sum += (sfb_true ^ lb_true ? ab[index] : -5.31);
        Sum += (sfb_true ^ lb_true ? ab[index] : local_double);
        Sum += (sfb_true ^ lb_true ? ab[index] : static_field_double);
        Sum += (sfb_true ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ lb_true ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ lb_true ? ab[index] : ab[index]);
        Sum += (sfb_true ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ lb_true ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ lb_true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_163()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ lb_false ? 3.1 : 3.1);
        Sum += (sfb_true ^ lb_false ? 3.1 : -5.31);
        Sum += (sfb_true ^ lb_false ? 3.1 : local_double);
        Sum += (sfb_true ^ lb_false ? 3.1 : static_field_double);
        Sum += (sfb_true ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ lb_false ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ lb_false ? 3.1 : ab[index]);
        Sum += (sfb_true ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ lb_false ? -5.31 : 3.1);
        Sum += (sfb_true ^ lb_false ? -5.31 : -5.31);
        Sum += (sfb_true ^ lb_false ? -5.31 : local_double);
        Sum += (sfb_true ^ lb_false ? -5.31 : static_field_double);
        Sum += (sfb_true ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ lb_false ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ lb_false ? -5.31 : ab[index]);
        Sum += (sfb_true ^ lb_false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_164()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ lb_false ? local_double : 3.1);
        Sum += (sfb_true ^ lb_false ? local_double : -5.31);
        Sum += (sfb_true ^ lb_false ? local_double : local_double);
        Sum += (sfb_true ^ lb_false ? local_double : static_field_double);
        Sum += (sfb_true ^ lb_false ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ lb_false ? local_double : simple_func_double());
        Sum += (sfb_true ^ lb_false ? local_double : ab[index]);
        Sum += (sfb_true ^ lb_false ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ lb_false ? static_field_double : 3.1);
        Sum += (sfb_true ^ lb_false ? static_field_double : -5.31);
        Sum += (sfb_true ^ lb_false ? static_field_double : local_double);
        Sum += (sfb_true ^ lb_false ? static_field_double : static_field_double);
        Sum += (sfb_true ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ lb_false ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ lb_false ? static_field_double : ab[index]);
        Sum += (sfb_true ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ lb_false ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ lb_false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_165()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ lb_false ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ lb_false ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ lb_false ? simple_func_double() : local_double);
        Sum += (sfb_true ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ lb_false ? ab[index] : 3.1);
        Sum += (sfb_true ^ lb_false ? ab[index] : -5.31);
        Sum += (sfb_true ^ lb_false ? ab[index] : local_double);
        Sum += (sfb_true ^ lb_false ? ab[index] : static_field_double);
        Sum += (sfb_true ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ lb_false ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ lb_false ? ab[index] : ab[index]);
        Sum += (sfb_true ^ lb_false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_166()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ lb_false ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ sfb_true ? 3.1 : 3.1);
        Sum += (sfb_true ^ sfb_true ? 3.1 : -5.31);
        Sum += (sfb_true ^ sfb_true ? 3.1 : local_double);
        Sum += (sfb_true ^ sfb_true ? 3.1 : static_field_double);
        Sum += (sfb_true ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ sfb_true ? 3.1 : ab[index]);
        Sum += (sfb_true ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ sfb_true ? -5.31 : 3.1);
        Sum += (sfb_true ^ sfb_true ? -5.31 : -5.31);
        Sum += (sfb_true ^ sfb_true ? -5.31 : local_double);
        Sum += (sfb_true ^ sfb_true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_167()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ sfb_true ? -5.31 : ab[index]);
        Sum += (sfb_true ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ sfb_true ? local_double : 3.1);
        Sum += (sfb_true ^ sfb_true ? local_double : -5.31);
        Sum += (sfb_true ^ sfb_true ? local_double : local_double);
        Sum += (sfb_true ^ sfb_true ? local_double : static_field_double);
        Sum += (sfb_true ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ sfb_true ? local_double : simple_func_double());
        Sum += (sfb_true ^ sfb_true ? local_double : ab[index]);
        Sum += (sfb_true ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ sfb_true ? static_field_double : 3.1);
        Sum += (sfb_true ^ sfb_true ? static_field_double : -5.31);
        Sum += (sfb_true ^ sfb_true ? static_field_double : local_double);
        Sum += (sfb_true ^ sfb_true ? static_field_double : static_field_double);
        Sum += (sfb_true ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ sfb_true ? static_field_double : ab[index]);
        Sum += (sfb_true ^ sfb_true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_168()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ sfb_true ? simple_func_double() : local_double);
        Sum += (sfb_true ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ sfb_true ? ab[index] : 3.1);
        Sum += (sfb_true ^ sfb_true ? ab[index] : -5.31);
        Sum += (sfb_true ^ sfb_true ? ab[index] : local_double);
        Sum += (sfb_true ^ sfb_true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_169()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ sfb_true ? ab[index] : ab[index]);
        Sum += (sfb_true ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ sfb_false ? 3.1 : 3.1);
        Sum += (sfb_true ^ sfb_false ? 3.1 : -5.31);
        Sum += (sfb_true ^ sfb_false ? 3.1 : local_double);
        Sum += (sfb_true ^ sfb_false ? 3.1 : static_field_double);
        Sum += (sfb_true ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ sfb_false ? 3.1 : ab[index]);
        Sum += (sfb_true ^ sfb_false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_170()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ sfb_false ? -5.31 : 3.1);
        Sum += (sfb_true ^ sfb_false ? -5.31 : -5.31);
        Sum += (sfb_true ^ sfb_false ? -5.31 : local_double);
        Sum += (sfb_true ^ sfb_false ? -5.31 : static_field_double);
        Sum += (sfb_true ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ sfb_false ? -5.31 : ab[index]);
        Sum += (sfb_true ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ sfb_false ? local_double : 3.1);
        Sum += (sfb_true ^ sfb_false ? local_double : -5.31);
        Sum += (sfb_true ^ sfb_false ? local_double : local_double);
        Sum += (sfb_true ^ sfb_false ? local_double : static_field_double);
        Sum += (sfb_true ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ sfb_false ? local_double : simple_func_double());
        Sum += (sfb_true ^ sfb_false ? local_double : ab[index]);
        Sum += (sfb_true ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ sfb_false ? static_field_double : 3.1);
        Sum += (sfb_true ^ sfb_false ? static_field_double : -5.31);
        Sum += (sfb_true ^ sfb_false ? static_field_double : local_double);
        Sum += (sfb_true ^ sfb_false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_171()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ sfb_false ? static_field_double : ab[index]);
        Sum += (sfb_true ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ sfb_false ? simple_func_double() : local_double);
        Sum += (sfb_true ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ sfb_false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_172()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ sfb_false ? ab[index] : 3.1);
        Sum += (sfb_true ^ sfb_false ? ab[index] : -5.31);
        Sum += (sfb_true ^ sfb_false ? ab[index] : local_double);
        Sum += (sfb_true ^ sfb_false ? ab[index] : static_field_double);
        Sum += (sfb_true ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ sfb_false ? ab[index] : ab[index]);
        Sum += (sfb_true ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_173()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_174()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_175()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_176()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_177()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_178()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_179()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (sfb_true ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (sfb_true ^ func_sb_true() ? 3.1 : local_double);
        Sum += (sfb_true ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (sfb_true ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (sfb_true ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (sfb_true ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (sfb_true ^ func_sb_true() ? -5.31 : local_double);
        Sum += (sfb_true ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (sfb_true ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (sfb_true ^ func_sb_true() ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_180()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ func_sb_true() ? local_double : 3.1);
        Sum += (sfb_true ^ func_sb_true() ? local_double : -5.31);
        Sum += (sfb_true ^ func_sb_true() ? local_double : local_double);
        Sum += (sfb_true ^ func_sb_true() ? local_double : static_field_double);
        Sum += (sfb_true ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (sfb_true ^ func_sb_true() ? local_double : ab[index]);
        Sum += (sfb_true ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (sfb_true ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (sfb_true ^ func_sb_true() ? static_field_double : local_double);
        Sum += (sfb_true ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (sfb_true ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (sfb_true ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ func_sb_true() ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_181()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (sfb_true ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (sfb_true ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (sfb_true ^ func_sb_true() ? ab[index] : local_double);
        Sum += (sfb_true ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (sfb_true ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (sfb_true ^ func_sb_true() ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_182()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (sfb_true ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (sfb_true ^ func_sb_false() ? 3.1 : local_double);
        Sum += (sfb_true ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (sfb_true ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (sfb_true ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (sfb_true ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (sfb_true ^ func_sb_false() ? -5.31 : local_double);
        Sum += (sfb_true ^ func_sb_false() ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_183()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (sfb_true ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_false() ? local_double : 3.1);
        Sum += (sfb_true ^ func_sb_false() ? local_double : -5.31);
        Sum += (sfb_true ^ func_sb_false() ? local_double : local_double);
        Sum += (sfb_true ^ func_sb_false() ? local_double : static_field_double);
        Sum += (sfb_true ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (sfb_true ^ func_sb_false() ? local_double : ab[index]);
        Sum += (sfb_true ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (sfb_true ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (sfb_true ^ func_sb_false() ? static_field_double : local_double);
        Sum += (sfb_true ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (sfb_true ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (sfb_true ^ func_sb_false() ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_184()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (sfb_true ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (sfb_true ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (sfb_true ^ func_sb_false() ? ab[index] : local_double);
        Sum += (sfb_true ^ func_sb_false() ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_185()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (sfb_true ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (sfb_true ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (sfb_true ^ ab_true[index] ? 3.1 : local_double);
        Sum += (sfb_true ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (sfb_true ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (sfb_true ^ ab_true[index] ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_186()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (sfb_true ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (sfb_true ^ ab_true[index] ? -5.31 : local_double);
        Sum += (sfb_true ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (sfb_true ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (sfb_true ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ ab_true[index] ? local_double : 3.1);
        Sum += (sfb_true ^ ab_true[index] ? local_double : -5.31);
        Sum += (sfb_true ^ ab_true[index] ? local_double : local_double);
        Sum += (sfb_true ^ ab_true[index] ? local_double : static_field_double);
        Sum += (sfb_true ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (sfb_true ^ ab_true[index] ? local_double : ab[index]);
        Sum += (sfb_true ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (sfb_true ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (sfb_true ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (sfb_true ^ ab_true[index] ? static_field_double : local_double);
        Sum += (sfb_true ^ ab_true[index] ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_187()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (sfb_true ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (sfb_true ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (sfb_true ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_188()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (sfb_true ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (sfb_true ^ ab_true[index] ? ab[index] : local_double);
        Sum += (sfb_true ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (sfb_true ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (sfb_true ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_true ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (sfb_true ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (sfb_true ^ ab_false[index] ? 3.1 : local_double);
        Sum += (sfb_true ^ ab_false[index] ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_189()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (sfb_true ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (sfb_true ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (sfb_true ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (sfb_true ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (sfb_true ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (sfb_true ^ ab_false[index] ? -5.31 : local_double);
        Sum += (sfb_true ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (sfb_true ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (sfb_true ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (sfb_true ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (sfb_true ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (sfb_true ^ ab_false[index] ? local_double : 3.1);
        Sum += (sfb_true ^ ab_false[index] ? local_double : -5.31);
        Sum += (sfb_true ^ ab_false[index] ? local_double : local_double);
        Sum += (sfb_true ^ ab_false[index] ? local_double : static_field_double);
        Sum += (sfb_true ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (sfb_true ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (sfb_true ^ ab_false[index] ? local_double : ab[index]);
        Sum += (sfb_true ^ ab_false[index] ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_190()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (sfb_true ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (sfb_true ^ ab_false[index] ? static_field_double : local_double);
        Sum += (sfb_true ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (sfb_true ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (sfb_true ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (sfb_true ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (sfb_true ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (sfb_true ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (sfb_true ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (sfb_true ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (sfb_true ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (sfb_true ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_true ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (sfb_true ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (sfb_true ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_true ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (sfb_true ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (sfb_true ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (sfb_true ^ ab_false[index] ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_191()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_true ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_true ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (sfb_true ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (sfb_true ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_true ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (sfb_true ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (sfb_true ^ ab_false[index] ? ab[index] : local_double);
        Sum += (sfb_true ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (sfb_true ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (sfb_true ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (sfb_true ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (sfb_true ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (sfb_true ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (sfb_true ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (sfb_true ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (sfb_true ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (sfb_true ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_true ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (sfb_true ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (sfb_true ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_192()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ true ? 3.1 : 3.1);
        Sum += (sfb_false ^ true ? 3.1 : -5.31);
        Sum += (sfb_false ^ true ? 3.1 : local_double);
        Sum += (sfb_false ^ true ? 3.1 : static_field_double);
        Sum += (sfb_false ^ true ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ true ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ true ? 3.1 : ab[index]);
        Sum += (sfb_false ^ true ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ true ? -5.31 : 3.1);
        Sum += (sfb_false ^ true ? -5.31 : -5.31);
        Sum += (sfb_false ^ true ? -5.31 : local_double);
        Sum += (sfb_false ^ true ? -5.31 : static_field_double);
        Sum += (sfb_false ^ true ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ true ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ true ? -5.31 : ab[index]);
        Sum += (sfb_false ^ true ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ true ? local_double : 3.1);
        Sum += (sfb_false ^ true ? local_double : -5.31);
        Sum += (sfb_false ^ true ? local_double : local_double);
        Sum += (sfb_false ^ true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_193()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ true ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ true ? local_double : simple_func_double());
        Sum += (sfb_false ^ true ? local_double : ab[index]);
        Sum += (sfb_false ^ true ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ true ? static_field_double : 3.1);
        Sum += (sfb_false ^ true ? static_field_double : -5.31);
        Sum += (sfb_false ^ true ? static_field_double : local_double);
        Sum += (sfb_false ^ true ? static_field_double : static_field_double);
        Sum += (sfb_false ^ true ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ true ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ true ? static_field_double : ab[index]);
        Sum += (sfb_false ^ true ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ true ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ true ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ true ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ true ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ true ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ true ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_194()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ true ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ true ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ true ? simple_func_double() : local_double);
        Sum += (sfb_false ^ true ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ true ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ true ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ true ? ab[index] : 3.1);
        Sum += (sfb_false ^ true ? ab[index] : -5.31);
        Sum += (sfb_false ^ true ? ab[index] : local_double);
        Sum += (sfb_false ^ true ? ab[index] : static_field_double);
        Sum += (sfb_false ^ true ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ true ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ true ? ab[index] : ab[index]);
        Sum += (sfb_false ^ true ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ true ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ true ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ true ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_195()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ true ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ true ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ false ? 3.1 : 3.1);
        Sum += (sfb_false ^ false ? 3.1 : -5.31);
        Sum += (sfb_false ^ false ? 3.1 : local_double);
        Sum += (sfb_false ^ false ? 3.1 : static_field_double);
        Sum += (sfb_false ^ false ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ false ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ false ? 3.1 : ab[index]);
        Sum += (sfb_false ^ false ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ false ? -5.31 : 3.1);
        Sum += (sfb_false ^ false ? -5.31 : -5.31);
        Sum += (sfb_false ^ false ? -5.31 : local_double);
        Sum += (sfb_false ^ false ? -5.31 : static_field_double);
        Sum += (sfb_false ^ false ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ false ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ false ? -5.31 : ab[index]);
        Sum += (sfb_false ^ false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_196()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ false ? local_double : 3.1);
        Sum += (sfb_false ^ false ? local_double : -5.31);
        Sum += (sfb_false ^ false ? local_double : local_double);
        Sum += (sfb_false ^ false ? local_double : static_field_double);
        Sum += (sfb_false ^ false ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ false ? local_double : simple_func_double());
        Sum += (sfb_false ^ false ? local_double : ab[index]);
        Sum += (sfb_false ^ false ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ false ? static_field_double : 3.1);
        Sum += (sfb_false ^ false ? static_field_double : -5.31);
        Sum += (sfb_false ^ false ? static_field_double : local_double);
        Sum += (sfb_false ^ false ? static_field_double : static_field_double);
        Sum += (sfb_false ^ false ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ false ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ false ? static_field_double : ab[index]);
        Sum += (sfb_false ^ false ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ false ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ false ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ false ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_197()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ false ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ false ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ false ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ false ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ false ? simple_func_double() : local_double);
        Sum += (sfb_false ^ false ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ false ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ false ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ false ? ab[index] : 3.1);
        Sum += (sfb_false ^ false ? ab[index] : -5.31);
        Sum += (sfb_false ^ false ? ab[index] : local_double);
        Sum += (sfb_false ^ false ? ab[index] : static_field_double);
        Sum += (sfb_false ^ false ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ false ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ false ? ab[index] : ab[index]);
        Sum += (sfb_false ^ false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_198()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ false ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ false ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ false ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ false ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ false ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ false ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ lb_true ? 3.1 : 3.1);
        Sum += (sfb_false ^ lb_true ? 3.1 : -5.31);
        Sum += (sfb_false ^ lb_true ? 3.1 : local_double);
        Sum += (sfb_false ^ lb_true ? 3.1 : static_field_double);
        Sum += (sfb_false ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ lb_true ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ lb_true ? 3.1 : ab[index]);
        Sum += (sfb_false ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ lb_true ? -5.31 : 3.1);
        Sum += (sfb_false ^ lb_true ? -5.31 : -5.31);
        Sum += (sfb_false ^ lb_true ? -5.31 : local_double);
        Sum += (sfb_false ^ lb_true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_199()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ lb_true ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ lb_true ? -5.31 : ab[index]);
        Sum += (sfb_false ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ lb_true ? local_double : 3.1);
        Sum += (sfb_false ^ lb_true ? local_double : -5.31);
        Sum += (sfb_false ^ lb_true ? local_double : local_double);
        Sum += (sfb_false ^ lb_true ? local_double : static_field_double);
        Sum += (sfb_false ^ lb_true ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ lb_true ? local_double : simple_func_double());
        Sum += (sfb_false ^ lb_true ? local_double : ab[index]);
        Sum += (sfb_false ^ lb_true ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ lb_true ? static_field_double : 3.1);
        Sum += (sfb_false ^ lb_true ? static_field_double : -5.31);
        Sum += (sfb_false ^ lb_true ? static_field_double : local_double);
        Sum += (sfb_false ^ lb_true ? static_field_double : static_field_double);
        Sum += (sfb_false ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ lb_true ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ lb_true ? static_field_double : ab[index]);
        Sum += (sfb_false ^ lb_true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_200()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ lb_true ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ lb_true ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ lb_true ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ lb_true ? simple_func_double() : local_double);
        Sum += (sfb_false ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ lb_true ? ab[index] : 3.1);
        Sum += (sfb_false ^ lb_true ? ab[index] : -5.31);
        Sum += (sfb_false ^ lb_true ? ab[index] : local_double);
        Sum += (sfb_false ^ lb_true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_201()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ lb_true ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ lb_true ? ab[index] : ab[index]);
        Sum += (sfb_false ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ lb_true ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ lb_false ? 3.1 : 3.1);
        Sum += (sfb_false ^ lb_false ? 3.1 : -5.31);
        Sum += (sfb_false ^ lb_false ? 3.1 : local_double);
        Sum += (sfb_false ^ lb_false ? 3.1 : static_field_double);
        Sum += (sfb_false ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ lb_false ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ lb_false ? 3.1 : ab[index]);
        Sum += (sfb_false ^ lb_false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_202()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ lb_false ? -5.31 : 3.1);
        Sum += (sfb_false ^ lb_false ? -5.31 : -5.31);
        Sum += (sfb_false ^ lb_false ? -5.31 : local_double);
        Sum += (sfb_false ^ lb_false ? -5.31 : static_field_double);
        Sum += (sfb_false ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ lb_false ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ lb_false ? -5.31 : ab[index]);
        Sum += (sfb_false ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ lb_false ? local_double : 3.1);
        Sum += (sfb_false ^ lb_false ? local_double : -5.31);
        Sum += (sfb_false ^ lb_false ? local_double : local_double);
        Sum += (sfb_false ^ lb_false ? local_double : static_field_double);
        Sum += (sfb_false ^ lb_false ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ lb_false ? local_double : simple_func_double());
        Sum += (sfb_false ^ lb_false ? local_double : ab[index]);
        Sum += (sfb_false ^ lb_false ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ lb_false ? static_field_double : 3.1);
        Sum += (sfb_false ^ lb_false ? static_field_double : -5.31);
        Sum += (sfb_false ^ lb_false ? static_field_double : local_double);
        Sum += (sfb_false ^ lb_false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_203()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ lb_false ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ lb_false ? static_field_double : ab[index]);
        Sum += (sfb_false ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ lb_false ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ lb_false ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ lb_false ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ lb_false ? simple_func_double() : local_double);
        Sum += (sfb_false ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ lb_false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_204()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ lb_false ? ab[index] : 3.1);
        Sum += (sfb_false ^ lb_false ? ab[index] : -5.31);
        Sum += (sfb_false ^ lb_false ? ab[index] : local_double);
        Sum += (sfb_false ^ lb_false ? ab[index] : static_field_double);
        Sum += (sfb_false ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ lb_false ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ lb_false ? ab[index] : ab[index]);
        Sum += (sfb_false ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ lb_false ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ sfb_true ? 3.1 : 3.1);
        Sum += (sfb_false ^ sfb_true ? 3.1 : -5.31);
        Sum += (sfb_false ^ sfb_true ? 3.1 : local_double);
        Sum += (sfb_false ^ sfb_true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_205()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ sfb_true ? 3.1 : ab[index]);
        Sum += (sfb_false ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ sfb_true ? -5.31 : 3.1);
        Sum += (sfb_false ^ sfb_true ? -5.31 : -5.31);
        Sum += (sfb_false ^ sfb_true ? -5.31 : local_double);
        Sum += (sfb_false ^ sfb_true ? -5.31 : static_field_double);
        Sum += (sfb_false ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ sfb_true ? -5.31 : ab[index]);
        Sum += (sfb_false ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ sfb_true ? local_double : 3.1);
        Sum += (sfb_false ^ sfb_true ? local_double : -5.31);
        Sum += (sfb_false ^ sfb_true ? local_double : local_double);
        Sum += (sfb_false ^ sfb_true ? local_double : static_field_double);
        Sum += (sfb_false ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ sfb_true ? local_double : simple_func_double());
        Sum += (sfb_false ^ sfb_true ? local_double : ab[index]);
        Sum += (sfb_false ^ sfb_true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_206()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ sfb_true ? static_field_double : 3.1);
        Sum += (sfb_false ^ sfb_true ? static_field_double : -5.31);
        Sum += (sfb_false ^ sfb_true ? static_field_double : local_double);
        Sum += (sfb_false ^ sfb_true ? static_field_double : static_field_double);
        Sum += (sfb_false ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ sfb_true ? static_field_double : ab[index]);
        Sum += (sfb_false ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ sfb_true ? simple_func_double() : local_double);
        Sum += (sfb_false ^ sfb_true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_207()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ sfb_true ? ab[index] : 3.1);
        Sum += (sfb_false ^ sfb_true ? ab[index] : -5.31);
        Sum += (sfb_false ^ sfb_true ? ab[index] : local_double);
        Sum += (sfb_false ^ sfb_true ? ab[index] : static_field_double);
        Sum += (sfb_false ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ sfb_true ? ab[index] : ab[index]);
        Sum += (sfb_false ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_208()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ sfb_false ? 3.1 : 3.1);
        Sum += (sfb_false ^ sfb_false ? 3.1 : -5.31);
        Sum += (sfb_false ^ sfb_false ? 3.1 : local_double);
        Sum += (sfb_false ^ sfb_false ? 3.1 : static_field_double);
        Sum += (sfb_false ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ sfb_false ? 3.1 : ab[index]);
        Sum += (sfb_false ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ sfb_false ? -5.31 : 3.1);
        Sum += (sfb_false ^ sfb_false ? -5.31 : -5.31);
        Sum += (sfb_false ^ sfb_false ? -5.31 : local_double);
        Sum += (sfb_false ^ sfb_false ? -5.31 : static_field_double);
        Sum += (sfb_false ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ sfb_false ? -5.31 : ab[index]);
        Sum += (sfb_false ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ sfb_false ? local_double : 3.1);
        Sum += (sfb_false ^ sfb_false ? local_double : -5.31);
        Sum += (sfb_false ^ sfb_false ? local_double : local_double);
        Sum += (sfb_false ^ sfb_false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_209()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ sfb_false ? local_double : simple_func_double());
        Sum += (sfb_false ^ sfb_false ? local_double : ab[index]);
        Sum += (sfb_false ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ sfb_false ? static_field_double : 3.1);
        Sum += (sfb_false ^ sfb_false ? static_field_double : -5.31);
        Sum += (sfb_false ^ sfb_false ? static_field_double : local_double);
        Sum += (sfb_false ^ sfb_false ? static_field_double : static_field_double);
        Sum += (sfb_false ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ sfb_false ? static_field_double : ab[index]);
        Sum += (sfb_false ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_210()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ sfb_false ? simple_func_double() : local_double);
        Sum += (sfb_false ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ sfb_false ? ab[index] : 3.1);
        Sum += (sfb_false ^ sfb_false ? ab[index] : -5.31);
        Sum += (sfb_false ^ sfb_false ? ab[index] : local_double);
        Sum += (sfb_false ^ sfb_false ? ab[index] : static_field_double);
        Sum += (sfb_false ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ sfb_false ? ab[index] : ab[index]);
        Sum += (sfb_false ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ sfb_false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_211()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_212()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_213()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_214()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_215()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_216()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_217()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (sfb_false ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (sfb_false ^ func_sb_true() ? 3.1 : local_double);
        Sum += (sfb_false ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (sfb_false ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (sfb_false ^ func_sb_true() ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_218()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (sfb_false ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (sfb_false ^ func_sb_true() ? -5.31 : local_double);
        Sum += (sfb_false ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (sfb_false ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (sfb_false ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_true() ? local_double : 3.1);
        Sum += (sfb_false ^ func_sb_true() ? local_double : -5.31);
        Sum += (sfb_false ^ func_sb_true() ? local_double : local_double);
        Sum += (sfb_false ^ func_sb_true() ? local_double : static_field_double);
        Sum += (sfb_false ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (sfb_false ^ func_sb_true() ? local_double : ab[index]);
        Sum += (sfb_false ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (sfb_false ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (sfb_false ^ func_sb_true() ? static_field_double : local_double);
        Sum += (sfb_false ^ func_sb_true() ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_219()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (sfb_false ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (sfb_false ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_220()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (sfb_false ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (sfb_false ^ func_sb_true() ? ab[index] : local_double);
        Sum += (sfb_false ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (sfb_false ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (sfb_false ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (sfb_false ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (sfb_false ^ func_sb_false() ? 3.1 : local_double);
        Sum += (sfb_false ^ func_sb_false() ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_221()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (sfb_false ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (sfb_false ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (sfb_false ^ func_sb_false() ? -5.31 : local_double);
        Sum += (sfb_false ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (sfb_false ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (sfb_false ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_false() ? local_double : 3.1);
        Sum += (sfb_false ^ func_sb_false() ? local_double : -5.31);
        Sum += (sfb_false ^ func_sb_false() ? local_double : local_double);
        Sum += (sfb_false ^ func_sb_false() ? local_double : static_field_double);
        Sum += (sfb_false ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (sfb_false ^ func_sb_false() ? local_double : ab[index]);
        Sum += (sfb_false ^ func_sb_false() ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_222()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (sfb_false ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (sfb_false ^ func_sb_false() ? static_field_double : local_double);
        Sum += (sfb_false ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (sfb_false ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (sfb_false ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (sfb_false ^ func_sb_false() ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_223()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (sfb_false ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (sfb_false ^ func_sb_false() ? ab[index] : local_double);
        Sum += (sfb_false ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (sfb_false ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (sfb_false ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_224()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (sfb_false ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (sfb_false ^ ab_true[index] ? 3.1 : local_double);
        Sum += (sfb_false ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (sfb_false ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (sfb_false ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (sfb_false ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (sfb_false ^ ab_true[index] ? -5.31 : local_double);
        Sum += (sfb_false ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (sfb_false ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (sfb_false ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (sfb_false ^ ab_true[index] ? local_double : 3.1);
        Sum += (sfb_false ^ ab_true[index] ? local_double : -5.31);
        Sum += (sfb_false ^ ab_true[index] ? local_double : local_double);
        Sum += (sfb_false ^ ab_true[index] ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_225()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (sfb_false ^ ab_true[index] ? local_double : ab[index]);
        Sum += (sfb_false ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (sfb_false ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (sfb_false ^ ab_true[index] ? static_field_double : local_double);
        Sum += (sfb_false ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (sfb_false ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (sfb_false ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (sfb_false ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_226()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (sfb_false ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (sfb_false ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (sfb_false ^ ab_true[index] ? ab[index] : local_double);
        Sum += (sfb_false ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (sfb_false ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (sfb_false ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (sfb_false ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ ab_true[index] ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_227()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (sfb_false ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (sfb_false ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (sfb_false ^ ab_false[index] ? 3.1 : local_double);
        Sum += (sfb_false ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (sfb_false ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (sfb_false ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (sfb_false ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (sfb_false ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (sfb_false ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (sfb_false ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (sfb_false ^ ab_false[index] ? -5.31 : local_double);
        Sum += (sfb_false ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (sfb_false ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (sfb_false ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (sfb_false ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (sfb_false ^ ab_false[index] ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_228()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ ab_false[index] ? local_double : 3.1);
        Sum += (sfb_false ^ ab_false[index] ? local_double : -5.31);
        Sum += (sfb_false ^ ab_false[index] ? local_double : local_double);
        Sum += (sfb_false ^ ab_false[index] ? local_double : static_field_double);
        Sum += (sfb_false ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (sfb_false ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (sfb_false ^ ab_false[index] ? local_double : ab[index]);
        Sum += (sfb_false ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (sfb_false ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (sfb_false ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (sfb_false ^ ab_false[index] ? static_field_double : local_double);
        Sum += (sfb_false ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (sfb_false ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (sfb_false ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (sfb_false ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (sfb_false ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (sfb_false ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (sfb_false ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (sfb_false ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (sfb_false ^ ab_false[index] ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_229()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (sfb_false ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (sfb_false ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (sfb_false ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (sfb_false ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (sfb_false ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (sfb_false ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (sfb_false ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (sfb_false ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (sfb_false ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (sfb_false ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (sfb_false ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (sfb_false ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (sfb_false ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (sfb_false ^ ab_false[index] ? ab[index] : local_double);
        Sum += (sfb_false ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (sfb_false ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (sfb_false ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (sfb_false ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (sfb_false ^ ab_false[index] ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_230()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (sfb_false ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (sfb_false ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (sfb_false ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (sfb_false ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (sfb_false ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (sfb_false ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (sfb_false ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (sfb_false ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ true ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ true ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ true ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ true ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ true ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ true ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ true ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ true ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ true ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ true ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ true ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_231()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ true ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ true ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ true ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ true ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ true ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ true ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ true ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ true ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ true ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ true ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ true ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ true ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ true ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ true ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ true ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ true ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ true ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ true ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ true ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_232()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ true ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ true ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ true ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ true ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ true ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ true ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ true ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ true ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ true ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ true ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ true ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ true ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ true ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ true ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ true ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_233()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ true ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ true ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ true ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ true ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ true ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ true ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ true ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ true ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ true ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ true ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ false ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ false ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ false ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ false ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ false ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ false ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ false ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_234()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ false ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ false ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ false ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ false ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ false ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ false ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ false ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ false ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ false ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ false ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ false ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ false ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ false ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ false ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ false ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ false ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ false ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ false ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ false ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_235()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ false ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ false ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ false ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ false ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ false ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ false ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ false ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ false ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ false ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ false ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ false ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ false ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ false ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ false ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ false ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ false ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_236()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ false ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ false ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ false ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ false ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ false ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ false ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ false ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ false ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ false ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ false ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ false ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ false ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ false ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ false ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_true ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ lb_true ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ lb_true ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ lb_true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_237()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_true ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_true ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_true ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ lb_true ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ lb_true ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ lb_true ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_true ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_true ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_true ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ lb_true ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ lb_true ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ lb_true ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_true ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_true ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_true ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_238()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ lb_true ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ lb_true ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ lb_true ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ lb_true ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_true ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_true ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ lb_true ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_true ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ lb_true ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ lb_true ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ lb_true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_239()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_240()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ lb_false ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ lb_false ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ lb_false ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ lb_false ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_false ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_false ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_false ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ lb_false ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ lb_false ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ lb_false ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_false ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_false ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_false ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ lb_false ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ lb_false ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ lb_false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_241()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ lb_false ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_false ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_false ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_false ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_false ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ lb_false ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ lb_false ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ lb_false ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_false ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_false ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ lb_false ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_242()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ lb_false ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ lb_false ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ lb_false ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_243()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_true ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_true ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_true ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_true ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_true ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_true ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_true ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_true ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_244()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ sfb_true ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_true ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_true ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_true ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_true ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_true ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_true ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_true ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_true ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_245()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_true ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_246()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_false ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_false ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_false ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_false ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_false ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_false ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_false ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_247()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_false ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_false ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_false ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_false ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_false ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_false ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_false ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_false ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_false ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_false ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_248()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_false ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_249()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_250()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_251()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_252()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_253()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_254()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_255()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_256()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_257()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_true() ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_258()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_259()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_260()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ func_sb_false() ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_false() ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_261()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_262()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_263()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_true[index] ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_264()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_265()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? 3.1 : local_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_266()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? -5.31 : local_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? local_double : 3.1);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? local_double : -5.31);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? local_double : local_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? local_double : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_false[index] ? local_double : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? static_field_double : local_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_267()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_268()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index] : local_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_true ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ true ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ true ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ true ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_269()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ true ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ true ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ true ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ true ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ true ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ true ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ true ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ true ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ true ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ true ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ true ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ true ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ true ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ true ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ true ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ true ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ true ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ true ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ true ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_270()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ true ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ true ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ true ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ true ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ true ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ true ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ true ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ true ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ true ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ true ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ true ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ true ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ true ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ true ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ true ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ true ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ true ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_271()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ true ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ true ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ true ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ true ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ true ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ true ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ true ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ true ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ true ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ true ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ true ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ true ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ true ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ true ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ true ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ true ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_272()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ false ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ false ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ false ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ false ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ false ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ false ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ false ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ false ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ false ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ false ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ false ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ false ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ false ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ false ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ false ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ false ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ false ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ false ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ false ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_273()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ false ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ false ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ false ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ false ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ false ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ false ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ false ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ false ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ false ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ false ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ false ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ false ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ false ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ false ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ false ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ false ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ false ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ false ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_274()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ false ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ false ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ false ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ false ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ false ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ false ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ false ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ false ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ false ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ false ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ false ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ false ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ false ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ false ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ false ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ false ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ false ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_275()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ false ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ false ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_true ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ lb_true ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ lb_true ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ lb_true ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_true ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_true ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_true ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ lb_true ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ lb_true ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ lb_true ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_true ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_true ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_276()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ lb_true ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ lb_true ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ lb_true ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ lb_true ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_true ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_true ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_true ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_true ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_true ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ lb_true ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ lb_true ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ lb_true ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_true ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_true ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ lb_true ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ lb_true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_277()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_true ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ lb_true ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ lb_true ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_278()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_false ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ lb_false ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ lb_false ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ lb_false ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_false ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_false ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_false ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ lb_false ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ lb_false ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ lb_false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_279()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_false ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_false ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_false ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ lb_false ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ lb_false ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ lb_false ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_false ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_false ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_false ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_false ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_false ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ lb_false ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ lb_false ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ lb_false ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_false ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_false ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_280()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ lb_false ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_false ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ lb_false ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ lb_false ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_281()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_true ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_true ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_true ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_true ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_282()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ sfb_true ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_true ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_true ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_true ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_true ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_true ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_true ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_true ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_true ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_true ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_true ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_true ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_283()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_true ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_true ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_284()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_false ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_false ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_false ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_285()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_false ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_false ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_false ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_false ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_false ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_false ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_false ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_false ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_false ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_false ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_286()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ sfb_false ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_false ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_false ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_false ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_false ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_287()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_288()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_289()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_290()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_291()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_292()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_293()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_294()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_295()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_true() ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_296()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_297()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_298()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_false() ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_299()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_300()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_301()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? local_double : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_true[index] ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_302()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_303()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_304()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? 3.1 : local_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? -5.31 : local_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? local_double : 3.1);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? local_double : -5.31);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? local_double : local_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_305()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_false[index] ? local_double : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? static_field_double : local_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_306()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index] : local_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_307()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (t1_i.mfb_false ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ true ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ true ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ true ? 3.1 : local_double);
        Sum += (func_sb_true() ^ true ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ true ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ true ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ true ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ true ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ true ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ true ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ true ? -5.31 : local_double);
        Sum += (func_sb_true() ^ true ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ true ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ true ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ true ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_308()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ true ? local_double : 3.1);
        Sum += (func_sb_true() ^ true ? local_double : -5.31);
        Sum += (func_sb_true() ^ true ? local_double : local_double);
        Sum += (func_sb_true() ^ true ? local_double : static_field_double);
        Sum += (func_sb_true() ^ true ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ true ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ true ? local_double : ab[index]);
        Sum += (func_sb_true() ^ true ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ true ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ true ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ true ? static_field_double : local_double);
        Sum += (func_sb_true() ^ true ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ true ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ true ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ true ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ true ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ true ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ true ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ true ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_309()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ true ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ true ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ true ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ true ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ true ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ true ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ true ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ true ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ true ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ true ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ true ? ab[index] : local_double);
        Sum += (func_sb_true() ^ true ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ true ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ true ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ true ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_310()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ true ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ true ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ true ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ true ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ true ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ true ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ false ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ false ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ false ? 3.1 : local_double);
        Sum += (func_sb_true() ^ false ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ false ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ false ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ false ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ false ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ false ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ false ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ false ? -5.31 : local_double);
        Sum += (func_sb_true() ^ false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_311()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ false ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ false ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ false ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ false ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ false ? local_double : 3.1);
        Sum += (func_sb_true() ^ false ? local_double : -5.31);
        Sum += (func_sb_true() ^ false ? local_double : local_double);
        Sum += (func_sb_true() ^ false ? local_double : static_field_double);
        Sum += (func_sb_true() ^ false ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ false ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ false ? local_double : ab[index]);
        Sum += (func_sb_true() ^ false ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ false ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ false ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ false ? static_field_double : local_double);
        Sum += (func_sb_true() ^ false ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ false ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ false ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ false ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_312()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ false ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ false ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ false ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ false ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ false ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ false ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ false ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ false ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ false ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ false ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ false ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ false ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ false ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ false ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ false ? ab[index] : local_double);
        Sum += (func_sb_true() ^ false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_313()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ false ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ false ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ false ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ false ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ false ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ false ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ false ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ false ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ false ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ false ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_true ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ lb_true ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ lb_true ? 3.1 : local_double);
        Sum += (func_sb_true() ^ lb_true ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_true ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ lb_true ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ lb_true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_314()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ lb_true ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ lb_true ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ lb_true ? -5.31 : local_double);
        Sum += (func_sb_true() ^ lb_true ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_true ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ lb_true ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_true ? local_double : 3.1);
        Sum += (func_sb_true() ^ lb_true ? local_double : -5.31);
        Sum += (func_sb_true() ^ lb_true ? local_double : local_double);
        Sum += (func_sb_true() ^ lb_true ? local_double : static_field_double);
        Sum += (func_sb_true() ^ lb_true ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_true ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ lb_true ? local_double : ab[index]);
        Sum += (func_sb_true() ^ lb_true ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_true ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ lb_true ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ lb_true ? static_field_double : local_double);
        Sum += (func_sb_true() ^ lb_true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_315()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_true ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ lb_true ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ lb_true ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_true ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ lb_true ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ lb_true ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ lb_true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_316()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ lb_true ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ lb_true ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ lb_true ? ab[index] : local_double);
        Sum += (func_sb_true() ^ lb_true ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_true ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ lb_true ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ lb_true ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_false ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ lb_false ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ lb_false ? 3.1 : local_double);
        Sum += (func_sb_true() ^ lb_false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_317()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_false ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ lb_false ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_false ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ lb_false ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ lb_false ? -5.31 : local_double);
        Sum += (func_sb_true() ^ lb_false ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_false ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ lb_false ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_false ? local_double : 3.1);
        Sum += (func_sb_true() ^ lb_false ? local_double : -5.31);
        Sum += (func_sb_true() ^ lb_false ? local_double : local_double);
        Sum += (func_sb_true() ^ lb_false ? local_double : static_field_double);
        Sum += (func_sb_true() ^ lb_false ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_false ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ lb_false ? local_double : ab[index]);
        Sum += (func_sb_true() ^ lb_false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_318()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ lb_false ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ lb_false ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ lb_false ? static_field_double : local_double);
        Sum += (func_sb_true() ^ lb_false ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_false ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ lb_false ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ lb_false ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_false ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ lb_false ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ lb_false ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ lb_false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_319()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_false ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ lb_false ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ lb_false ? ab[index] : local_double);
        Sum += (func_sb_true() ^ lb_false ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_false ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ lb_false ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ lb_false ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ lb_false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_320()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ sfb_true ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ sfb_true ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ sfb_true ? 3.1 : local_double);
        Sum += (func_sb_true() ^ sfb_true ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ sfb_true ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_true ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ sfb_true ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ sfb_true ? -5.31 : local_double);
        Sum += (func_sb_true() ^ sfb_true ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ sfb_true ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_true ? local_double : 3.1);
        Sum += (func_sb_true() ^ sfb_true ? local_double : -5.31);
        Sum += (func_sb_true() ^ sfb_true ? local_double : local_double);
        Sum += (func_sb_true() ^ sfb_true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_321()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_true ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ sfb_true ? local_double : ab[index]);
        Sum += (func_sb_true() ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_true ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ sfb_true ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ sfb_true ? static_field_double : local_double);
        Sum += (func_sb_true() ^ sfb_true ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ sfb_true ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_322()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ sfb_true ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_true ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ sfb_true ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ sfb_true ? ab[index] : local_double);
        Sum += (func_sb_true() ^ sfb_true ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ sfb_true ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ sfb_true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_323()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_false ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ sfb_false ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ sfb_false ? 3.1 : local_double);
        Sum += (func_sb_true() ^ sfb_false ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ sfb_false ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_false ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ sfb_false ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ sfb_false ? -5.31 : local_double);
        Sum += (func_sb_true() ^ sfb_false ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ sfb_false ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ sfb_false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_324()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ sfb_false ? local_double : 3.1);
        Sum += (func_sb_true() ^ sfb_false ? local_double : -5.31);
        Sum += (func_sb_true() ^ sfb_false ? local_double : local_double);
        Sum += (func_sb_true() ^ sfb_false ? local_double : static_field_double);
        Sum += (func_sb_true() ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_false ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ sfb_false ? local_double : ab[index]);
        Sum += (func_sb_true() ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_false ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ sfb_false ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ sfb_false ? static_field_double : local_double);
        Sum += (func_sb_true() ^ sfb_false ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ sfb_false ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ sfb_false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_325()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ sfb_false ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ sfb_false ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ sfb_false ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ sfb_false ? ab[index] : local_double);
        Sum += (func_sb_true() ^ sfb_false ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ sfb_false ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ sfb_false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_326()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_327()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_328()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_329()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_330()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_331()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_332()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ func_sb_true() ? 3.1 : local_double);
        Sum += (func_sb_true() ^ func_sb_true() ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_333()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ func_sb_true() ? -5.31 : local_double);
        Sum += (func_sb_true() ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_true() ? local_double : 3.1);
        Sum += (func_sb_true() ^ func_sb_true() ? local_double : -5.31);
        Sum += (func_sb_true() ^ func_sb_true() ? local_double : local_double);
        Sum += (func_sb_true() ^ func_sb_true() ? local_double : static_field_double);
        Sum += (func_sb_true() ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_true() ? local_double : ab[index]);
        Sum += (func_sb_true() ^ func_sb_true() ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_334()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ func_sb_true() ? static_field_double : local_double);
        Sum += (func_sb_true() ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ func_sb_true() ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_335()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index] : local_double);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_336()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ func_sb_false() ? 3.1 : local_double);
        Sum += (func_sb_true() ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ func_sb_false() ? -5.31 : local_double);
        Sum += (func_sb_true() ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_false() ? local_double : 3.1);
        Sum += (func_sb_true() ^ func_sb_false() ? local_double : -5.31);
        Sum += (func_sb_true() ^ func_sb_false() ? local_double : local_double);
        Sum += (func_sb_true() ^ func_sb_false() ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_337()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_false() ? local_double : ab[index]);
        Sum += (func_sb_true() ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ func_sb_false() ? static_field_double : local_double);
        Sum += (func_sb_true() ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_338()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index] : local_double);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_339()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ ab_true[index] ? 3.1 : local_double);
        Sum += (func_sb_true() ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ ab_true[index] ? -5.31 : local_double);
        Sum += (func_sb_true() ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (func_sb_true() ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ ab_true[index] ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_340()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ ab_true[index] ? local_double : 3.1);
        Sum += (func_sb_true() ^ ab_true[index] ? local_double : -5.31);
        Sum += (func_sb_true() ^ ab_true[index] ? local_double : local_double);
        Sum += (func_sb_true() ^ ab_true[index] ? local_double : static_field_double);
        Sum += (func_sb_true() ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ ab_true[index] ? local_double : ab[index]);
        Sum += (func_sb_true() ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ ab_true[index] ? static_field_double : local_double);
        Sum += (func_sb_true() ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ ab_true[index] ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_341()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index] : local_double);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_342()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (func_sb_true() ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (func_sb_true() ^ ab_false[index] ? 3.1 : local_double);
        Sum += (func_sb_true() ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (func_sb_true() ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (func_sb_true() ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (func_sb_true() ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (func_sb_true() ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (func_sb_true() ^ ab_false[index] ? -5.31 : local_double);
        Sum += (func_sb_true() ^ ab_false[index] ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_343()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (func_sb_true() ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (func_sb_true() ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_false[index] ? local_double : 3.1);
        Sum += (func_sb_true() ^ ab_false[index] ? local_double : -5.31);
        Sum += (func_sb_true() ^ ab_false[index] ? local_double : local_double);
        Sum += (func_sb_true() ^ ab_false[index] ? local_double : static_field_double);
        Sum += (func_sb_true() ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (func_sb_true() ^ ab_false[index] ? local_double : ab[index]);
        Sum += (func_sb_true() ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (func_sb_true() ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (func_sb_true() ^ ab_false[index] ? static_field_double : local_double);
        Sum += (func_sb_true() ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (func_sb_true() ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (func_sb_true() ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (func_sb_true() ^ ab_false[index] ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_344()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (func_sb_true() ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (func_sb_true() ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (func_sb_true() ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (func_sb_true() ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_true() ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (func_sb_true() ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (func_sb_true() ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (func_sb_true() ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (func_sb_true() ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (func_sb_true() ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (func_sb_true() ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (func_sb_true() ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index] : local_double);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_345()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (func_sb_true() ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ true ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ true ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ true ? 3.1 : local_double);
        Sum += (func_sb_false() ^ true ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ true ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ true ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ true ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_346()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ true ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ true ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ true ? -5.31 : local_double);
        Sum += (func_sb_false() ^ true ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ true ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ true ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ true ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ true ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ true ? local_double : 3.1);
        Sum += (func_sb_false() ^ true ? local_double : -5.31);
        Sum += (func_sb_false() ^ true ? local_double : local_double);
        Sum += (func_sb_false() ^ true ? local_double : static_field_double);
        Sum += (func_sb_false() ^ true ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ true ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ true ? local_double : ab[index]);
        Sum += (func_sb_false() ^ true ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ true ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ true ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ true ? static_field_double : local_double);
        Sum += (func_sb_false() ^ true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_347()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ true ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ true ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ true ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ true ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ true ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ true ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ true ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ true ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ true ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ true ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ true ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ true ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ true ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ true ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ true ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ true ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_348()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ true ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ true ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ true ? ab[index] : local_double);
        Sum += (func_sb_false() ^ true ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ true ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ true ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ true ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ true ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ true ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ true ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ true ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ true ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ true ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ true ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ false ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ false ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ false ? 3.1 : local_double);
        Sum += (func_sb_false() ^ false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_349()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ false ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ false ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ false ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ false ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ false ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ false ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ false ? -5.31 : local_double);
        Sum += (func_sb_false() ^ false ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ false ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ false ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ false ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ false ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ false ? local_double : 3.1);
        Sum += (func_sb_false() ^ false ? local_double : -5.31);
        Sum += (func_sb_false() ^ false ? local_double : local_double);
        Sum += (func_sb_false() ^ false ? local_double : static_field_double);
        Sum += (func_sb_false() ^ false ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ false ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ false ? local_double : ab[index]);
        Sum += (func_sb_false() ^ false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_350()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ false ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ false ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ false ? static_field_double : local_double);
        Sum += (func_sb_false() ^ false ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ false ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ false ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ false ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ false ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ false ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ false ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ false ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ false ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ false ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ false ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ false ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ false ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ false ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_351()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ false ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ false ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ false ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ false ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ false ? ab[index] : local_double);
        Sum += (func_sb_false() ^ false ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ false ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ false ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ false ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ false ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ false ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ false ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ false ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ false ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ false ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ false ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_352()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ lb_true ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ lb_true ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ lb_true ? 3.1 : local_double);
        Sum += (func_sb_false() ^ lb_true ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_true ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ lb_true ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_true ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ lb_true ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ lb_true ? -5.31 : local_double);
        Sum += (func_sb_false() ^ lb_true ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_true ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ lb_true ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_true ? local_double : 3.1);
        Sum += (func_sb_false() ^ lb_true ? local_double : -5.31);
        Sum += (func_sb_false() ^ lb_true ? local_double : local_double);
        Sum += (func_sb_false() ^ lb_true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_353()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ lb_true ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_true ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ lb_true ? local_double : ab[index]);
        Sum += (func_sb_false() ^ lb_true ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_true ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ lb_true ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ lb_true ? static_field_double : local_double);
        Sum += (func_sb_false() ^ lb_true ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_true ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ lb_true ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ lb_true ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ lb_true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_354()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ lb_true ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ lb_true ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ lb_true ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_true ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ lb_true ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ lb_true ? ab[index] : local_double);
        Sum += (func_sb_false() ^ lb_true ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_true ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ lb_true ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ lb_true ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ lb_true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_355()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_false ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ lb_false ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ lb_false ? 3.1 : local_double);
        Sum += (func_sb_false() ^ lb_false ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_false ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ lb_false ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_false ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ lb_false ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ lb_false ? -5.31 : local_double);
        Sum += (func_sb_false() ^ lb_false ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_false ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ lb_false ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ lb_false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_356()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ lb_false ? local_double : 3.1);
        Sum += (func_sb_false() ^ lb_false ? local_double : -5.31);
        Sum += (func_sb_false() ^ lb_false ? local_double : local_double);
        Sum += (func_sb_false() ^ lb_false ? local_double : static_field_double);
        Sum += (func_sb_false() ^ lb_false ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_false ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ lb_false ? local_double : ab[index]);
        Sum += (func_sb_false() ^ lb_false ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_false ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ lb_false ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ lb_false ? static_field_double : local_double);
        Sum += (func_sb_false() ^ lb_false ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_false ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ lb_false ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ lb_false ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ lb_false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_357()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_false ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ lb_false ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ lb_false ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ lb_false ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ lb_false ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ lb_false ? ab[index] : local_double);
        Sum += (func_sb_false() ^ lb_false ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_false ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ lb_false ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ lb_false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_358()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ lb_false ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_true ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ sfb_true ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ sfb_true ? 3.1 : local_double);
        Sum += (func_sb_false() ^ sfb_true ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ sfb_true ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_true ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ sfb_true ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ sfb_true ? -5.31 : local_double);
        Sum += (func_sb_false() ^ sfb_true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_359()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ sfb_true ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_true ? local_double : 3.1);
        Sum += (func_sb_false() ^ sfb_true ? local_double : -5.31);
        Sum += (func_sb_false() ^ sfb_true ? local_double : local_double);
        Sum += (func_sb_false() ^ sfb_true ? local_double : static_field_double);
        Sum += (func_sb_false() ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_true ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ sfb_true ? local_double : ab[index]);
        Sum += (func_sb_false() ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_true ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ sfb_true ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ sfb_true ? static_field_double : local_double);
        Sum += (func_sb_false() ^ sfb_true ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ sfb_true ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ sfb_true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_360()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ sfb_true ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_true ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ sfb_true ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ sfb_true ? ab[index] : local_double);
        Sum += (func_sb_false() ^ sfb_true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_361()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ sfb_true ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_false ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ sfb_false ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ sfb_false ? 3.1 : local_double);
        Sum += (func_sb_false() ^ sfb_false ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ sfb_false ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ sfb_false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_362()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ sfb_false ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ sfb_false ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ sfb_false ? -5.31 : local_double);
        Sum += (func_sb_false() ^ sfb_false ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ sfb_false ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_false ? local_double : 3.1);
        Sum += (func_sb_false() ^ sfb_false ? local_double : -5.31);
        Sum += (func_sb_false() ^ sfb_false ? local_double : local_double);
        Sum += (func_sb_false() ^ sfb_false ? local_double : static_field_double);
        Sum += (func_sb_false() ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_false ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ sfb_false ? local_double : ab[index]);
        Sum += (func_sb_false() ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_false ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ sfb_false ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ sfb_false ? static_field_double : local_double);
        Sum += (func_sb_false() ^ sfb_false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_363()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ sfb_false ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ sfb_false ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ sfb_false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_364()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ sfb_false ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ sfb_false ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ sfb_false ? ab[index] : local_double);
        Sum += (func_sb_false() ^ sfb_false ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ sfb_false ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_365()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_366()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_367()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_368()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_369()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_370()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_371()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ func_sb_true() ? 3.1 : local_double);
        Sum += (func_sb_false() ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ func_sb_true() ? -5.31 : local_double);
        Sum += (func_sb_false() ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ func_sb_true() ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_372()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ func_sb_true() ? local_double : 3.1);
        Sum += (func_sb_false() ^ func_sb_true() ? local_double : -5.31);
        Sum += (func_sb_false() ^ func_sb_true() ? local_double : local_double);
        Sum += (func_sb_false() ^ func_sb_true() ? local_double : static_field_double);
        Sum += (func_sb_false() ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_true() ? local_double : ab[index]);
        Sum += (func_sb_false() ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ func_sb_true() ? static_field_double : local_double);
        Sum += (func_sb_false() ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ func_sb_true() ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_373()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index] : local_double);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_374()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ func_sb_false() ? 3.1 : local_double);
        Sum += (func_sb_false() ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ func_sb_false() ? -5.31 : local_double);
        Sum += (func_sb_false() ^ func_sb_false() ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_375()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_false() ? local_double : 3.1);
        Sum += (func_sb_false() ^ func_sb_false() ? local_double : -5.31);
        Sum += (func_sb_false() ^ func_sb_false() ? local_double : local_double);
        Sum += (func_sb_false() ^ func_sb_false() ? local_double : static_field_double);
        Sum += (func_sb_false() ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_false() ? local_double : ab[index]);
        Sum += (func_sb_false() ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ func_sb_false() ? static_field_double : local_double);
        Sum += (func_sb_false() ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ func_sb_false() ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_376()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index] : local_double);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_377()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ ab_true[index] ? 3.1 : local_double);
        Sum += (func_sb_false() ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (func_sb_false() ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ ab_true[index] ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_378()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ ab_true[index] ? -5.31 : local_double);
        Sum += (func_sb_false() ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_true[index] ? local_double : 3.1);
        Sum += (func_sb_false() ^ ab_true[index] ? local_double : -5.31);
        Sum += (func_sb_false() ^ ab_true[index] ? local_double : local_double);
        Sum += (func_sb_false() ^ ab_true[index] ? local_double : static_field_double);
        Sum += (func_sb_false() ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ ab_true[index] ? local_double : ab[index]);
        Sum += (func_sb_false() ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ ab_true[index] ? static_field_double : local_double);
        Sum += (func_sb_false() ^ ab_true[index] ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_379()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (func_sb_false() ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_380()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index] : local_double);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (func_sb_false() ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (func_sb_false() ^ ab_false[index] ? 3.1 : local_double);
        Sum += (func_sb_false() ^ ab_false[index] ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_381()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (func_sb_false() ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (func_sb_false() ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (func_sb_false() ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (func_sb_false() ^ ab_false[index] ? -5.31 : local_double);
        Sum += (func_sb_false() ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (func_sb_false() ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (func_sb_false() ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (func_sb_false() ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_false[index] ? local_double : 3.1);
        Sum += (func_sb_false() ^ ab_false[index] ? local_double : -5.31);
        Sum += (func_sb_false() ^ ab_false[index] ? local_double : local_double);
        Sum += (func_sb_false() ^ ab_false[index] ? local_double : static_field_double);
        Sum += (func_sb_false() ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (func_sb_false() ^ ab_false[index] ? local_double : ab[index]);
        Sum += (func_sb_false() ^ ab_false[index] ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_382()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (func_sb_false() ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (func_sb_false() ^ ab_false[index] ? static_field_double : local_double);
        Sum += (func_sb_false() ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (func_sb_false() ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (func_sb_false() ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (func_sb_false() ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (func_sb_false() ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (func_sb_false() ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (func_sb_false() ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (func_sb_false() ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (func_sb_false() ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (func_sb_false() ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (func_sb_false() ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (func_sb_false() ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (func_sb_false() ^ ab_false[index] ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_383()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (func_sb_false() ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (func_sb_false() ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (func_sb_false() ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index] : local_double);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (func_sb_false() ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_384()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ true ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ true ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ true ? 3.1 : local_double);
        Sum += (ab_true[index] ^ true ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ true ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ true ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ true ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ true ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ true ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ true ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ true ? -5.31 : local_double);
        Sum += (ab_true[index] ^ true ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ true ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ true ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ true ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ true ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ true ? local_double : 3.1);
        Sum += (ab_true[index] ^ true ? local_double : -5.31);
        Sum += (ab_true[index] ^ true ? local_double : local_double);
        Sum += (ab_true[index] ^ true ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_385()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ true ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ true ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ true ? local_double : ab[index]);
        Sum += (ab_true[index] ^ true ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ true ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ true ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ true ? static_field_double : local_double);
        Sum += (ab_true[index] ^ true ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ true ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ true ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ true ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ true ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ true ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ true ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ true ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ true ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ true ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ true ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ true ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_386()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ true ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ true ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ true ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ true ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ true ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ true ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ true ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ true ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ true ? ab[index] : local_double);
        Sum += (ab_true[index] ^ true ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ true ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ true ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ true ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ true ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ true ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ true ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ true ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ true ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_387()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ true ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ true ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ false ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ false ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ false ? 3.1 : local_double);
        Sum += (ab_true[index] ^ false ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ false ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ false ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ false ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ false ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ false ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ false ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ false ? -5.31 : local_double);
        Sum += (ab_true[index] ^ false ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ false ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ false ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ false ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ false ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_388()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ false ? local_double : 3.1);
        Sum += (ab_true[index] ^ false ? local_double : -5.31);
        Sum += (ab_true[index] ^ false ? local_double : local_double);
        Sum += (ab_true[index] ^ false ? local_double : static_field_double);
        Sum += (ab_true[index] ^ false ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ false ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ false ? local_double : ab[index]);
        Sum += (ab_true[index] ^ false ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ false ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ false ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ false ? static_field_double : local_double);
        Sum += (ab_true[index] ^ false ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ false ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ false ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ false ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ false ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ false ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ false ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ false ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ false ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_389()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ false ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ false ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ false ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ false ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ false ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ false ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ false ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ false ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ false ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ false ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ false ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ false ? ab[index] : local_double);
        Sum += (ab_true[index] ^ false ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ false ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ false ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ false ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ false ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_390()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ false ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ false ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ false ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ false ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ false ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ false ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_true ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ lb_true ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ lb_true ? 3.1 : local_double);
        Sum += (ab_true[index] ^ lb_true ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_true ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ lb_true ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_true ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ lb_true ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ lb_true ? -5.31 : local_double);
        Sum += (ab_true[index] ^ lb_true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_391()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_true ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ lb_true ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_true ? local_double : 3.1);
        Sum += (ab_true[index] ^ lb_true ? local_double : -5.31);
        Sum += (ab_true[index] ^ lb_true ? local_double : local_double);
        Sum += (ab_true[index] ^ lb_true ? local_double : static_field_double);
        Sum += (ab_true[index] ^ lb_true ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_true ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ lb_true ? local_double : ab[index]);
        Sum += (ab_true[index] ^ lb_true ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_true ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ lb_true ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ lb_true ? static_field_double : local_double);
        Sum += (ab_true[index] ^ lb_true ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_true ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ lb_true ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ lb_true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_392()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ lb_true ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_true ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ lb_true ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ lb_true ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ lb_true ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_true ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ lb_true ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ lb_true ? ab[index] : local_double);
        Sum += (ab_true[index] ^ lb_true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_393()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_true ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ lb_true ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ lb_true ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ lb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_false ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ lb_false ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ lb_false ? 3.1 : local_double);
        Sum += (ab_true[index] ^ lb_false ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_false ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ lb_false ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ lb_false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_394()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ lb_false ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ lb_false ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ lb_false ? -5.31 : local_double);
        Sum += (ab_true[index] ^ lb_false ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_false ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ lb_false ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_false ? local_double : 3.1);
        Sum += (ab_true[index] ^ lb_false ? local_double : -5.31);
        Sum += (ab_true[index] ^ lb_false ? local_double : local_double);
        Sum += (ab_true[index] ^ lb_false ? local_double : static_field_double);
        Sum += (ab_true[index] ^ lb_false ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_false ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ lb_false ? local_double : ab[index]);
        Sum += (ab_true[index] ^ lb_false ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_false ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ lb_false ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ lb_false ? static_field_double : local_double);
        Sum += (ab_true[index] ^ lb_false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_395()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_false ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ lb_false ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ lb_false ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ lb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_false ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ lb_false ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ lb_false ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ lb_false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_396()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ lb_false ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ lb_false ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ lb_false ? ab[index] : local_double);
        Sum += (ab_true[index] ^ lb_false ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_false ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ lb_false ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ lb_false ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ lb_false ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_true ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ sfb_true ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ sfb_true ? 3.1 : local_double);
        Sum += (ab_true[index] ^ sfb_true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_397()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ sfb_true ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_true ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ sfb_true ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ sfb_true ? -5.31 : local_double);
        Sum += (ab_true[index] ^ sfb_true ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ sfb_true ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ sfb_true ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_true ? local_double : 3.1);
        Sum += (ab_true[index] ^ sfb_true ? local_double : -5.31);
        Sum += (ab_true[index] ^ sfb_true ? local_double : local_double);
        Sum += (ab_true[index] ^ sfb_true ? local_double : static_field_double);
        Sum += (ab_true[index] ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_true ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ sfb_true ? local_double : ab[index]);
        Sum += (ab_true[index] ^ sfb_true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_398()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ sfb_true ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ sfb_true ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ sfb_true ? static_field_double : local_double);
        Sum += (ab_true[index] ^ sfb_true ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ sfb_true ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ sfb_true ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ sfb_true ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ sfb_true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_399()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_true ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ sfb_true ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ sfb_true ? ab[index] : local_double);
        Sum += (ab_true[index] ^ sfb_true ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ sfb_true ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ sfb_true ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_400()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ sfb_false ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ sfb_false ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ sfb_false ? 3.1 : local_double);
        Sum += (ab_true[index] ^ sfb_false ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ sfb_false ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_false ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ sfb_false ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ sfb_false ? -5.31 : local_double);
        Sum += (ab_true[index] ^ sfb_false ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ sfb_false ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_false ? local_double : 3.1);
        Sum += (ab_true[index] ^ sfb_false ? local_double : -5.31);
        Sum += (ab_true[index] ^ sfb_false ? local_double : local_double);
        Sum += (ab_true[index] ^ sfb_false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_401()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_false ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ sfb_false ? local_double : ab[index]);
        Sum += (ab_true[index] ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_false ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ sfb_false ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ sfb_false ? static_field_double : local_double);
        Sum += (ab_true[index] ^ sfb_false ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ sfb_false ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ sfb_false ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_402()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ sfb_false ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_false ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ sfb_false ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ sfb_false ? ab[index] : local_double);
        Sum += (ab_true[index] ^ sfb_false ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ sfb_false ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ sfb_false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_403()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_404()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_405()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_406()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_407()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_408()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_409()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ func_sb_true() ? 3.1 : local_double);
        Sum += (ab_true[index] ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ func_sb_true() ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_410()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ func_sb_true() ? -5.31 : local_double);
        Sum += (ab_true[index] ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_true() ? local_double : 3.1);
        Sum += (ab_true[index] ^ func_sb_true() ? local_double : -5.31);
        Sum += (ab_true[index] ^ func_sb_true() ? local_double : local_double);
        Sum += (ab_true[index] ^ func_sb_true() ? local_double : static_field_double);
        Sum += (ab_true[index] ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_true() ? local_double : ab[index]);
        Sum += (ab_true[index] ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ func_sb_true() ? static_field_double : local_double);
        Sum += (ab_true[index] ^ func_sb_true() ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_411()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_412()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index] : local_double);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ func_sb_false() ? 3.1 : local_double);
        Sum += (ab_true[index] ^ func_sb_false() ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_413()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ func_sb_false() ? -5.31 : local_double);
        Sum += (ab_true[index] ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ func_sb_false() ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_false() ? local_double : 3.1);
        Sum += (ab_true[index] ^ func_sb_false() ? local_double : -5.31);
        Sum += (ab_true[index] ^ func_sb_false() ? local_double : local_double);
        Sum += (ab_true[index] ^ func_sb_false() ? local_double : static_field_double);
        Sum += (ab_true[index] ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_false() ? local_double : ab[index]);
        Sum += (ab_true[index] ^ func_sb_false() ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_414()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ func_sb_false() ? static_field_double : local_double);
        Sum += (ab_true[index] ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ func_sb_false() ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ func_sb_false() ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_415()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index] : local_double);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_416()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ ab_true[index] ? 3.1 : local_double);
        Sum += (ab_true[index] ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ ab_true[index] ? -5.31 : local_double);
        Sum += (ab_true[index] ^ ab_true[index] ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_true[index] ? local_double : 3.1);
        Sum += (ab_true[index] ^ ab_true[index] ? local_double : -5.31);
        Sum += (ab_true[index] ^ ab_true[index] ? local_double : local_double);
        Sum += (ab_true[index] ^ ab_true[index] ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_417()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ ab_true[index] ? local_double : ab[index]);
        Sum += (ab_true[index] ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ ab_true[index] ? static_field_double : local_double);
        Sum += (ab_true[index] ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ ab_true[index] ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (ab_true[index] ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_418()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index] : local_double);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_419()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (ab_true[index] ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (ab_true[index] ^ ab_false[index] ? 3.1 : local_double);
        Sum += (ab_true[index] ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (ab_true[index] ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (ab_true[index] ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (ab_true[index] ^ ab_false[index] ? 3.1 : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (ab_true[index] ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (ab_true[index] ^ ab_false[index] ? -5.31 : local_double);
        Sum += (ab_true[index] ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (ab_true[index] ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (ab_true[index] ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (ab_true[index] ^ ab_false[index] ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_420()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ ab_false[index] ? local_double : 3.1);
        Sum += (ab_true[index] ^ ab_false[index] ? local_double : -5.31);
        Sum += (ab_true[index] ^ ab_false[index] ? local_double : local_double);
        Sum += (ab_true[index] ^ ab_false[index] ? local_double : static_field_double);
        Sum += (ab_true[index] ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (ab_true[index] ^ ab_false[index] ? local_double : ab[index]);
        Sum += (ab_true[index] ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (ab_true[index] ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (ab_true[index] ^ ab_false[index] ? static_field_double : local_double);
        Sum += (ab_true[index] ^ ab_false[index] ? static_field_double : static_field_double);
        Sum += (ab_true[index] ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (ab_true[index] ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (ab_true[index] ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (ab_true[index] ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (ab_true[index] ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (ab_true[index] ^ ab_false[index] ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_421()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (ab_true[index] ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (ab_true[index] ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (ab_true[index] ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (ab_true[index] ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (ab_true[index] ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (ab_true[index] ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (ab_true[index] ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (ab_true[index] ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index] : local_double);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_422()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (ab_true[index] ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ true ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ true ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ true ? 3.1 : local_double);
        Sum += (ab_false[index] ^ true ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ true ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ true ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ true ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ true ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ true ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ true ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ true ? -5.31 : local_double);
        Sum += (ab_false[index] ^ true ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_423()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ true ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ true ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ true ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ true ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ true ? local_double : 3.1);
        Sum += (ab_false[index] ^ true ? local_double : -5.31);
        Sum += (ab_false[index] ^ true ? local_double : local_double);
        Sum += (ab_false[index] ^ true ? local_double : static_field_double);
        Sum += (ab_false[index] ^ true ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ true ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ true ? local_double : ab[index]);
        Sum += (ab_false[index] ^ true ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ true ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ true ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ true ? static_field_double : local_double);
        Sum += (ab_false[index] ^ true ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ true ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ true ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ true ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ true ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_424()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ true ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ true ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ true ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ true ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ true ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ true ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ true ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ true ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ true ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ true ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ true ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ true ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ true ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ true ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ true ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ true ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ true ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ true ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ true ? ab[index] : local_double);
        Sum += (ab_false[index] ^ true ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_425()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ true ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ true ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ true ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ true ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ true ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ true ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ true ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ true ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ true ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ true ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ true ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ true ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ false ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ false ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ false ? 3.1 : local_double);
        Sum += (ab_false[index] ^ false ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ false ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ false ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ false ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ false ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_426()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ false ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ false ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ false ? -5.31 : local_double);
        Sum += (ab_false[index] ^ false ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ false ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ false ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ false ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ false ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ false ? local_double : 3.1);
        Sum += (ab_false[index] ^ false ? local_double : -5.31);
        Sum += (ab_false[index] ^ false ? local_double : local_double);
        Sum += (ab_false[index] ^ false ? local_double : static_field_double);
        Sum += (ab_false[index] ^ false ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ false ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ false ? local_double : ab[index]);
        Sum += (ab_false[index] ^ false ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ false ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ false ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ false ? static_field_double : local_double);
        Sum += (ab_false[index] ^ false ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_427()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ false ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ false ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ false ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ false ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ false ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ false ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ false ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ false ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ false ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ false ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ false ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ false ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ false ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ false ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ false ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ false ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ false ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ false ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ false ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ false ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_428()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ false ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ false ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ false ? ab[index] : local_double);
        Sum += (ab_false[index] ^ false ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ false ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ false ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ false ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ false ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ false ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ false ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ false ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ false ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ false ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ false ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ false ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ false ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_true ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ lb_true ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ lb_true ? 3.1 : local_double);
        Sum += (ab_false[index] ^ lb_true ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_429()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ lb_true ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_true ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ lb_true ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ lb_true ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_true ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ lb_true ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ lb_true ? -5.31 : local_double);
        Sum += (ab_false[index] ^ lb_true ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ lb_true ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_true ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ lb_true ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ lb_true ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_true ? local_double : 3.1);
        Sum += (ab_false[index] ^ lb_true ? local_double : -5.31);
        Sum += (ab_false[index] ^ lb_true ? local_double : local_double);
        Sum += (ab_false[index] ^ lb_true ? local_double : static_field_double);
        Sum += (ab_false[index] ^ lb_true ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_true ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ lb_true ? local_double : ab[index]);
        Sum += (ab_false[index] ^ lb_true ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_430()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ lb_true ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ lb_true ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ lb_true ? static_field_double : local_double);
        Sum += (ab_false[index] ^ lb_true ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ lb_true ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_true ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ lb_true ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ lb_true ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_true ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ lb_true ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ lb_true ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ lb_true ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ lb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_true ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ lb_true ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ lb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_true ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ lb_true ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ lb_true ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ lb_true ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_431()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ lb_true ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_true ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ lb_true ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ lb_true ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_true ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ lb_true ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ lb_true ? ab[index] : local_double);
        Sum += (ab_false[index] ^ lb_true ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ lb_true ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_true ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ lb_true ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ lb_true ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_true ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ lb_true ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ lb_true ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ lb_true ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ lb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_true ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ lb_true ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ lb_true ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_432()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ lb_false ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ lb_false ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ lb_false ? 3.1 : local_double);
        Sum += (ab_false[index] ^ lb_false ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ lb_false ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_false ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ lb_false ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ lb_false ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_false ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ lb_false ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ lb_false ? -5.31 : local_double);
        Sum += (ab_false[index] ^ lb_false ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ lb_false ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_false ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ lb_false ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ lb_false ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_false ? local_double : 3.1);
        Sum += (ab_false[index] ^ lb_false ? local_double : -5.31);
        Sum += (ab_false[index] ^ lb_false ? local_double : local_double);
        Sum += (ab_false[index] ^ lb_false ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_433()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ lb_false ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_false ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ lb_false ? local_double : ab[index]);
        Sum += (ab_false[index] ^ lb_false ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_false ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ lb_false ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ lb_false ? static_field_double : local_double);
        Sum += (ab_false[index] ^ lb_false ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ lb_false ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_false ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ lb_false ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ lb_false ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_false ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ lb_false ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ lb_false ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ lb_false ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ lb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_false ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ lb_false ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ lb_false ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_434()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ lb_false ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ lb_false ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ lb_false ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ lb_false ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ lb_false ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_false ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ lb_false ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ lb_false ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_false ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ lb_false ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ lb_false ? ab[index] : local_double);
        Sum += (ab_false[index] ^ lb_false ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ lb_false ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_false ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ lb_false ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ lb_false ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ lb_false ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ lb_false ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ lb_false ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ lb_false ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_435()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ lb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ lb_false ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ lb_false ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ lb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_true ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ sfb_true ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ sfb_true ? 3.1 : local_double);
        Sum += (ab_false[index] ^ sfb_true ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ sfb_true ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_true ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ sfb_true ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ sfb_true ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_true ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ sfb_true ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ sfb_true ? -5.31 : local_double);
        Sum += (ab_false[index] ^ sfb_true ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ sfb_true ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_true ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ sfb_true ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ sfb_true ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_436()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ sfb_true ? local_double : 3.1);
        Sum += (ab_false[index] ^ sfb_true ? local_double : -5.31);
        Sum += (ab_false[index] ^ sfb_true ? local_double : local_double);
        Sum += (ab_false[index] ^ sfb_true ? local_double : static_field_double);
        Sum += (ab_false[index] ^ sfb_true ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_true ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ sfb_true ? local_double : ab[index]);
        Sum += (ab_false[index] ^ sfb_true ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_true ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ sfb_true ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ sfb_true ? static_field_double : local_double);
        Sum += (ab_false[index] ^ sfb_true ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ sfb_true ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_true ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ sfb_true ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ sfb_true ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_true ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ sfb_true ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ sfb_true ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ sfb_true ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_437()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ sfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_true ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ sfb_true ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ sfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_true ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ sfb_true ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ sfb_true ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ sfb_true ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ sfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_true ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ sfb_true ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ sfb_true ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_true ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ sfb_true ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ sfb_true ? ab[index] : local_double);
        Sum += (ab_false[index] ^ sfb_true ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ sfb_true ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_true ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ sfb_true ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ sfb_true ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_438()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ sfb_true ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ sfb_true ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ sfb_true ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ sfb_true ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ sfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_true ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ sfb_true ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ sfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_false ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ sfb_false ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ sfb_false ? 3.1 : local_double);
        Sum += (ab_false[index] ^ sfb_false ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ sfb_false ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_false ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ sfb_false ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ sfb_false ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_false ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ sfb_false ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ sfb_false ? -5.31 : local_double);
        Sum += (ab_false[index] ^ sfb_false ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_439()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ sfb_false ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_false ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ sfb_false ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ sfb_false ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_false ? local_double : 3.1);
        Sum += (ab_false[index] ^ sfb_false ? local_double : -5.31);
        Sum += (ab_false[index] ^ sfb_false ? local_double : local_double);
        Sum += (ab_false[index] ^ sfb_false ? local_double : static_field_double);
        Sum += (ab_false[index] ^ sfb_false ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_false ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ sfb_false ? local_double : ab[index]);
        Sum += (ab_false[index] ^ sfb_false ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_false ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ sfb_false ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ sfb_false ? static_field_double : local_double);
        Sum += (ab_false[index] ^ sfb_false ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ sfb_false ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_false ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ sfb_false ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ sfb_false ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_440()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ sfb_false ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ sfb_false ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ sfb_false ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ sfb_false ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ sfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_false ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ sfb_false ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ sfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_false ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ sfb_false ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ sfb_false ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ sfb_false ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ sfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_false ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ sfb_false ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ sfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_false ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ sfb_false ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ sfb_false ? ab[index] : local_double);
        Sum += (ab_false[index] ^ sfb_false ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_441()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ sfb_false ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_false ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ sfb_false ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ sfb_false ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ sfb_false ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ sfb_false ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ sfb_false ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ sfb_false ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ sfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ sfb_false ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ sfb_false ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ sfb_false ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? 3.1 : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_true ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_442()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ t1_i.mfb_true ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? -5.31 : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_true ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? local_double : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? local_double : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? local_double : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? local_double : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_true ? local_double : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? static_field_double : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_443()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ t1_i.mfb_true ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_true ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_true ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_true ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_444()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index] : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_true ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? 3.1 : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? 3.1 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_445()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ t1_i.mfb_false ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_false ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? -5.31 : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_false ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? local_double : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? local_double : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? local_double : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? local_double : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_false ? local_double : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? local_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_446()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ t1_i.mfb_false ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? static_field_double : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_false ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_false ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? simple_func_double() : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_447()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ t1_i.mfb_false ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_false ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index] : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ t1_i.mfb_false ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_448()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ func_sb_true() ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ func_sb_true() ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ func_sb_true() ? 3.1 : local_double);
        Sum += (ab_false[index] ^ func_sb_true() ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ func_sb_true() ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_true() ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_true() ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ func_sb_true() ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_true() ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ func_sb_true() ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ func_sb_true() ? -5.31 : local_double);
        Sum += (ab_false[index] ^ func_sb_true() ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ func_sb_true() ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_true() ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_true() ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ func_sb_true() ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_true() ? local_double : 3.1);
        Sum += (ab_false[index] ^ func_sb_true() ? local_double : -5.31);
        Sum += (ab_false[index] ^ func_sb_true() ? local_double : local_double);
        Sum += (ab_false[index] ^ func_sb_true() ? local_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_449()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ func_sb_true() ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_true() ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_true() ? local_double : ab[index]);
        Sum += (ab_false[index] ^ func_sb_true() ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_true() ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ func_sb_true() ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ func_sb_true() ? static_field_double : local_double);
        Sum += (ab_false[index] ^ func_sb_true() ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ func_sb_true() ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_true() ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_true() ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ func_sb_true() ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_true() ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ func_sb_true() ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ func_sb_true() ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ func_sb_true() ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ func_sb_true() ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_true() ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_true() ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ func_sb_true() ? t1_i.mfd : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_450()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ func_sb_true() ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ func_sb_true() ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ func_sb_true() ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ func_sb_true() ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ func_sb_true() ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_true() ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_true() ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ func_sb_true() ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index] : local_double);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index - 1] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_451()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ func_sb_true() ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_false() ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ func_sb_false() ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ func_sb_false() ? 3.1 : local_double);
        Sum += (ab_false[index] ^ func_sb_false() ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ func_sb_false() ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_false() ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_false() ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ func_sb_false() ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_false() ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ func_sb_false() ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ func_sb_false() ? -5.31 : local_double);
        Sum += (ab_false[index] ^ func_sb_false() ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ func_sb_false() ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_false() ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_false() ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ func_sb_false() ? -5.31 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_452()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ func_sb_false() ? local_double : 3.1);
        Sum += (ab_false[index] ^ func_sb_false() ? local_double : -5.31);
        Sum += (ab_false[index] ^ func_sb_false() ? local_double : local_double);
        Sum += (ab_false[index] ^ func_sb_false() ? local_double : static_field_double);
        Sum += (ab_false[index] ^ func_sb_false() ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_false() ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_false() ? local_double : ab[index]);
        Sum += (ab_false[index] ^ func_sb_false() ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_false() ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ func_sb_false() ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ func_sb_false() ? static_field_double : local_double);
        Sum += (ab_false[index] ^ func_sb_false() ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ func_sb_false() ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_false() ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_false() ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ func_sb_false() ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_false() ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ func_sb_false() ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ func_sb_false() ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ func_sb_false() ? t1_i.mfd : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_453()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ func_sb_false() ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_false() ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_false() ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ func_sb_false() ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_false() ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ func_sb_false() ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ func_sb_false() ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ func_sb_false() ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ func_sb_false() ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_false() ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_false() ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ func_sb_false() ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index] : local_double);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index] : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_454()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ func_sb_false() ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_true[index] ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ ab_true[index] ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ ab_true[index] ? 3.1 : local_double);
        Sum += (ab_false[index] ^ ab_true[index] ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ ab_true[index] ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_true[index] ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ ab_true[index] ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ ab_true[index] ? 3.1 : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_true[index] ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ ab_true[index] ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ ab_true[index] ? -5.31 : local_double);
        Sum += (ab_false[index] ^ ab_true[index] ? -5.31 : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_455()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ ab_true[index] ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_true[index] ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ ab_true[index] ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ ab_true[index] ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_true[index] ? local_double : 3.1);
        Sum += (ab_false[index] ^ ab_true[index] ? local_double : -5.31);
        Sum += (ab_false[index] ^ ab_true[index] ? local_double : local_double);
        Sum += (ab_false[index] ^ ab_true[index] ? local_double : static_field_double);
        Sum += (ab_false[index] ^ ab_true[index] ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_true[index] ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ ab_true[index] ? local_double : ab[index]);
        Sum += (ab_false[index] ^ ab_true[index] ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_true[index] ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ ab_true[index] ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ ab_true[index] ? static_field_double : local_double);
        Sum += (ab_false[index] ^ ab_true[index] ? static_field_double : static_field_double);
        Sum += (ab_false[index] ^ ab_true[index] ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_true[index] ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ ab_true[index] ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ ab_true[index] ? static_field_double : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_456()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ ab_true[index] ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ ab_true[index] ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ ab_true[index] ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ ab_true[index] ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ ab_true[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_true[index] ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ ab_true[index] ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ ab_true[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_true[index] ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ ab_true[index] ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ ab_true[index] ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ ab_true[index] ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ ab_true[index] ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_true[index] ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ ab_true[index] ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ ab_true[index] ? simple_func_double() : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index] : local_double);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index] : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_457()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ ab_true[index] ? ab[index - 1] : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_false[index] ? 3.1 : 3.1);
        Sum += (ab_false[index] ^ ab_false[index] ? 3.1 : -5.31);
        Sum += (ab_false[index] ^ ab_false[index] ? 3.1 : local_double);
        Sum += (ab_false[index] ^ ab_false[index] ? 3.1 : static_field_double);
        Sum += (ab_false[index] ^ ab_false[index] ? 3.1 : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_false[index] ? 3.1 : simple_func_double());
        Sum += (ab_false[index] ^ ab_false[index] ? 3.1 : ab[index]);
        Sum += (ab_false[index] ^ ab_false[index] ? 3.1 : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_458()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ ab_false[index] ? -5.31 : 3.1);
        Sum += (ab_false[index] ^ ab_false[index] ? -5.31 : -5.31);
        Sum += (ab_false[index] ^ ab_false[index] ? -5.31 : local_double);
        Sum += (ab_false[index] ^ ab_false[index] ? -5.31 : static_field_double);
        Sum += (ab_false[index] ^ ab_false[index] ? -5.31 : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_false[index] ? -5.31 : simple_func_double());
        Sum += (ab_false[index] ^ ab_false[index] ? -5.31 : ab[index]);
        Sum += (ab_false[index] ^ ab_false[index] ? -5.31 : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_false[index] ? local_double : 3.1);
        Sum += (ab_false[index] ^ ab_false[index] ? local_double : -5.31);
        Sum += (ab_false[index] ^ ab_false[index] ? local_double : local_double);
        Sum += (ab_false[index] ^ ab_false[index] ? local_double : static_field_double);
        Sum += (ab_false[index] ^ ab_false[index] ? local_double : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_false[index] ? local_double : simple_func_double());
        Sum += (ab_false[index] ^ ab_false[index] ? local_double : ab[index]);
        Sum += (ab_false[index] ^ ab_false[index] ? local_double : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_false[index] ? static_field_double : 3.1);
        Sum += (ab_false[index] ^ ab_false[index] ? static_field_double : -5.31);
        Sum += (ab_false[index] ^ ab_false[index] ? static_field_double : local_double);
        Sum += (ab_false[index] ^ ab_false[index] ? static_field_double : static_field_double);
        return Sum;
    }
    static double Sub_Funclet_459()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ ab_false[index] ? static_field_double : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_false[index] ? static_field_double : simple_func_double());
        Sum += (ab_false[index] ^ ab_false[index] ? static_field_double : ab[index]);
        Sum += (ab_false[index] ^ ab_false[index] ? static_field_double : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_false[index] ? t1_i.mfd : 3.1);
        Sum += (ab_false[index] ^ ab_false[index] ? t1_i.mfd : -5.31);
        Sum += (ab_false[index] ^ ab_false[index] ? t1_i.mfd : local_double);
        Sum += (ab_false[index] ^ ab_false[index] ? t1_i.mfd : static_field_double);
        Sum += (ab_false[index] ^ ab_false[index] ? t1_i.mfd : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_false[index] ? t1_i.mfd : simple_func_double());
        Sum += (ab_false[index] ^ ab_false[index] ? t1_i.mfd : ab[index]);
        Sum += (ab_false[index] ^ ab_false[index] ? t1_i.mfd : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_false[index] ? simple_func_double() : 3.1);
        Sum += (ab_false[index] ^ ab_false[index] ? simple_func_double() : -5.31);
        Sum += (ab_false[index] ^ ab_false[index] ? simple_func_double() : local_double);
        Sum += (ab_false[index] ^ ab_false[index] ? simple_func_double() : static_field_double);
        Sum += (ab_false[index] ^ ab_false[index] ? simple_func_double() : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_false[index] ? simple_func_double() : simple_func_double());
        Sum += (ab_false[index] ^ ab_false[index] ? simple_func_double() : ab[index]);
        Sum += (ab_false[index] ^ ab_false[index] ? simple_func_double() : ab[index - 1]);
        return Sum;
    }
    static double Sub_Funclet_460()
    {
        double Sum = 0.0;
        int index = 1;
        double local_double = -5.2;
        bool lb_false = false;
        bool lb_true = true;
        testout1 t1_i = new testout1();
        bool[] ab_false = new bool[3];
        bool[] ab_true = new bool[3];
        ab_true[0] = true;
        ab_true[1] = true;
        ab_true[2] = true;
        double[] ab = new double[3];
        ab[0] = 21.2;
        ab[1] = -27.645;
        ab[2] = -31.987;

        static_field_double = 7.7777;
        sfb_false = false;
        sfb_true = true;

        t1_i.mfd = -13.777;
        t1_i.mfb_false = false;
        t1_i.mfb_true = true;
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index] : 3.1);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index] : -5.31);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index] : local_double);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index] : static_field_double);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index] : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index] : simple_func_double());
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index] : ab[index]);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index] : ab[index - 1]);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index - 1] : 3.1);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index - 1] : -5.31);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index - 1] : local_double);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index - 1] : static_field_double);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index - 1] : t1_i.mfd);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index - 1] : simple_func_double());
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index - 1] : ab[index]);
        Sum += (ab_false[index] ^ ab_false[index] ? ab[index - 1] : ab[index - 1]);
        return Sum;
    }
    [Fact]
    public static int TestEntryPoint()
    {
        double Sum = 0;
        Sum += Sub_Funclet_0();
        Sum += Sub_Funclet_1();
        Sum += Sub_Funclet_2();
        Sum += Sub_Funclet_3();
        Sum += Sub_Funclet_4();
        Sum += Sub_Funclet_5();
        Sum += Sub_Funclet_6();
        Sum += Sub_Funclet_7();
        Sum += Sub_Funclet_8();
        Sum += Sub_Funclet_9();
        Sum += Sub_Funclet_10();
        Sum += Sub_Funclet_11();
        Sum += Sub_Funclet_12();
        Sum += Sub_Funclet_13();
        Sum += Sub_Funclet_14();
        Sum += Sub_Funclet_15();
        Sum += Sub_Funclet_16();
        Sum += Sub_Funclet_17();
        Sum += Sub_Funclet_18();
        Sum += Sub_Funclet_19();
        Sum += Sub_Funclet_20();
        Sum += Sub_Funclet_21();
        Sum += Sub_Funclet_22();
        Sum += Sub_Funclet_23();
        Sum += Sub_Funclet_24();
        Sum += Sub_Funclet_25();
        Sum += Sub_Funclet_26();
        Sum += Sub_Funclet_27();
        Sum += Sub_Funclet_28();
        Sum += Sub_Funclet_29();
        Sum += Sub_Funclet_30();
        Sum += Sub_Funclet_31();
        Sum += Sub_Funclet_32();
        Sum += Sub_Funclet_33();
        Sum += Sub_Funclet_34();
        Sum += Sub_Funclet_35();
        Sum += Sub_Funclet_36();
        Sum += Sub_Funclet_37();
        Sum += Sub_Funclet_38();
        Sum += Sub_Funclet_39();
        Sum += Sub_Funclet_40();
        Sum += Sub_Funclet_41();
        Sum += Sub_Funclet_42();
        Sum += Sub_Funclet_43();
        Sum += Sub_Funclet_44();
        Sum += Sub_Funclet_45();
        Sum += Sub_Funclet_46();
        Sum += Sub_Funclet_47();
        Sum += Sub_Funclet_48();
        Sum += Sub_Funclet_49();
        Sum += Sub_Funclet_50();
        Sum += Sub_Funclet_51();
        Sum += Sub_Funclet_52();
        Sum += Sub_Funclet_53();
        Sum += Sub_Funclet_54();
        Sum += Sub_Funclet_55();
        Sum += Sub_Funclet_56();
        Sum += Sub_Funclet_57();
        Sum += Sub_Funclet_58();
        Sum += Sub_Funclet_59();
        Sum += Sub_Funclet_60();
        Sum += Sub_Funclet_61();
        Sum += Sub_Funclet_62();
        Sum += Sub_Funclet_63();
        Sum += Sub_Funclet_64();
        Sum += Sub_Funclet_65();
        Sum += Sub_Funclet_66();
        Sum += Sub_Funclet_67();
        Sum += Sub_Funclet_68();
        Sum += Sub_Funclet_69();
        Sum += Sub_Funclet_70();
        Sum += Sub_Funclet_71();
        Sum += Sub_Funclet_72();
        Sum += Sub_Funclet_73();
        Sum += Sub_Funclet_74();
        Sum += Sub_Funclet_75();
        Sum += Sub_Funclet_76();
        Sum += Sub_Funclet_77();
        Sum += Sub_Funclet_78();
        Sum += Sub_Funclet_79();
        Sum += Sub_Funclet_80();
        Sum += Sub_Funclet_81();
        Sum += Sub_Funclet_82();
        Sum += Sub_Funclet_83();
        Sum += Sub_Funclet_84();
        Sum += Sub_Funclet_85();
        Sum += Sub_Funclet_86();
        Sum += Sub_Funclet_87();
        Sum += Sub_Funclet_88();
        Sum += Sub_Funclet_89();
        Sum += Sub_Funclet_90();
        Sum += Sub_Funclet_91();
        Sum += Sub_Funclet_92();
        Sum += Sub_Funclet_93();
        Sum += Sub_Funclet_94();
        Sum += Sub_Funclet_95();
        Sum += Sub_Funclet_96();
        Sum += Sub_Funclet_97();
        Sum += Sub_Funclet_98();
        Sum += Sub_Funclet_99();
        Sum += Sub_Funclet_100();
        Sum += Sub_Funclet_101();
        Sum += Sub_Funclet_102();
        Sum += Sub_Funclet_103();
        Sum += Sub_Funclet_104();
        Sum += Sub_Funclet_105();
        Sum += Sub_Funclet_106();
        Sum += Sub_Funclet_107();
        Sum += Sub_Funclet_108();
        Sum += Sub_Funclet_109();
        Sum += Sub_Funclet_110();
        Sum += Sub_Funclet_111();
        Sum += Sub_Funclet_112();
        Sum += Sub_Funclet_113();
        Sum += Sub_Funclet_114();
        Sum += Sub_Funclet_115();
        Sum += Sub_Funclet_116();
        Sum += Sub_Funclet_117();
        Sum += Sub_Funclet_118();
        Sum += Sub_Funclet_119();
        Sum += Sub_Funclet_120();
        Sum += Sub_Funclet_121();
        Sum += Sub_Funclet_122();
        Sum += Sub_Funclet_123();
        Sum += Sub_Funclet_124();
        Sum += Sub_Funclet_125();
        Sum += Sub_Funclet_126();
        Sum += Sub_Funclet_127();
        Sum += Sub_Funclet_128();
        Sum += Sub_Funclet_129();
        Sum += Sub_Funclet_130();
        Sum += Sub_Funclet_131();
        Sum += Sub_Funclet_132();
        Sum += Sub_Funclet_133();
        Sum += Sub_Funclet_134();
        Sum += Sub_Funclet_135();
        Sum += Sub_Funclet_136();
        Sum += Sub_Funclet_137();
        Sum += Sub_Funclet_138();
        Sum += Sub_Funclet_139();
        Sum += Sub_Funclet_140();
        Sum += Sub_Funclet_141();
        Sum += Sub_Funclet_142();
        Sum += Sub_Funclet_143();
        Sum += Sub_Funclet_144();
        Sum += Sub_Funclet_145();
        Sum += Sub_Funclet_146();
        Sum += Sub_Funclet_147();
        Sum += Sub_Funclet_148();
        Sum += Sub_Funclet_149();
        Sum += Sub_Funclet_150();
        Sum += Sub_Funclet_151();
        Sum += Sub_Funclet_152();
        Sum += Sub_Funclet_153();
        Sum += Sub_Funclet_154();
        Sum += Sub_Funclet_155();
        Sum += Sub_Funclet_156();
        Sum += Sub_Funclet_157();
        Sum += Sub_Funclet_158();
        Sum += Sub_Funclet_159();
        Sum += Sub_Funclet_160();
        Sum += Sub_Funclet_161();
        Sum += Sub_Funclet_162();
        Sum += Sub_Funclet_163();
        Sum += Sub_Funclet_164();
        Sum += Sub_Funclet_165();
        Sum += Sub_Funclet_166();
        Sum += Sub_Funclet_167();
        Sum += Sub_Funclet_168();
        Sum += Sub_Funclet_169();
        Sum += Sub_Funclet_170();
        Sum += Sub_Funclet_171();
        Sum += Sub_Funclet_172();
        Sum += Sub_Funclet_173();
        Sum += Sub_Funclet_174();
        Sum += Sub_Funclet_175();
        Sum += Sub_Funclet_176();
        Sum += Sub_Funclet_177();
        Sum += Sub_Funclet_178();
        Sum += Sub_Funclet_179();
        Sum += Sub_Funclet_180();
        Sum += Sub_Funclet_181();
        Sum += Sub_Funclet_182();
        Sum += Sub_Funclet_183();
        Sum += Sub_Funclet_184();
        Sum += Sub_Funclet_185();
        Sum += Sub_Funclet_186();
        Sum += Sub_Funclet_187();
        Sum += Sub_Funclet_188();
        Sum += Sub_Funclet_189();
        Sum += Sub_Funclet_190();
        Sum += Sub_Funclet_191();
        Sum += Sub_Funclet_192();
        Sum += Sub_Funclet_193();
        Sum += Sub_Funclet_194();
        Sum += Sub_Funclet_195();
        Sum += Sub_Funclet_196();
        Sum += Sub_Funclet_197();
        Sum += Sub_Funclet_198();
        Sum += Sub_Funclet_199();
        Sum += Sub_Funclet_200();
        Sum += Sub_Funclet_201();
        Sum += Sub_Funclet_202();
        Sum += Sub_Funclet_203();
        Sum += Sub_Funclet_204();
        Sum += Sub_Funclet_205();
        Sum += Sub_Funclet_206();
        Sum += Sub_Funclet_207();
        Sum += Sub_Funclet_208();
        Sum += Sub_Funclet_209();
        Sum += Sub_Funclet_210();
        Sum += Sub_Funclet_211();
        Sum += Sub_Funclet_212();
        Sum += Sub_Funclet_213();
        Sum += Sub_Funclet_214();
        Sum += Sub_Funclet_215();
        Sum += Sub_Funclet_216();
        Sum += Sub_Funclet_217();
        Sum += Sub_Funclet_218();
        Sum += Sub_Funclet_219();
        Sum += Sub_Funclet_220();
        Sum += Sub_Funclet_221();
        Sum += Sub_Funclet_222();
        Sum += Sub_Funclet_223();
        Sum += Sub_Funclet_224();
        Sum += Sub_Funclet_225();
        Sum += Sub_Funclet_226();
        Sum += Sub_Funclet_227();
        Sum += Sub_Funclet_228();
        Sum += Sub_Funclet_229();
        Sum += Sub_Funclet_230();
        Sum += Sub_Funclet_231();
        Sum += Sub_Funclet_232();
        Sum += Sub_Funclet_233();
        Sum += Sub_Funclet_234();
        Sum += Sub_Funclet_235();
        Sum += Sub_Funclet_236();
        Sum += Sub_Funclet_237();
        Sum += Sub_Funclet_238();
        Sum += Sub_Funclet_239();
        Sum += Sub_Funclet_240();
        Sum += Sub_Funclet_241();
        Sum += Sub_Funclet_242();
        Sum += Sub_Funclet_243();
        Sum += Sub_Funclet_244();
        Sum += Sub_Funclet_245();
        Sum += Sub_Funclet_246();
        Sum += Sub_Funclet_247();
        Sum += Sub_Funclet_248();
        Sum += Sub_Funclet_249();
        Sum += Sub_Funclet_250();
        Sum += Sub_Funclet_251();
        Sum += Sub_Funclet_252();
        Sum += Sub_Funclet_253();
        Sum += Sub_Funclet_254();
        Sum += Sub_Funclet_255();
        Sum += Sub_Funclet_256();
        Sum += Sub_Funclet_257();
        Sum += Sub_Funclet_258();
        Sum += Sub_Funclet_259();
        Sum += Sub_Funclet_260();
        Sum += Sub_Funclet_261();
        Sum += Sub_Funclet_262();
        Sum += Sub_Funclet_263();
        Sum += Sub_Funclet_264();
        Sum += Sub_Funclet_265();
        Sum += Sub_Funclet_266();
        Sum += Sub_Funclet_267();
        Sum += Sub_Funclet_268();
        Sum += Sub_Funclet_269();
        Sum += Sub_Funclet_270();
        Sum += Sub_Funclet_271();
        Sum += Sub_Funclet_272();
        Sum += Sub_Funclet_273();
        Sum += Sub_Funclet_274();
        Sum += Sub_Funclet_275();
        Sum += Sub_Funclet_276();
        Sum += Sub_Funclet_277();
        Sum += Sub_Funclet_278();
        Sum += Sub_Funclet_279();
        Sum += Sub_Funclet_280();
        Sum += Sub_Funclet_281();
        Sum += Sub_Funclet_282();
        Sum += Sub_Funclet_283();
        Sum += Sub_Funclet_284();
        Sum += Sub_Funclet_285();
        Sum += Sub_Funclet_286();
        Sum += Sub_Funclet_287();
        Sum += Sub_Funclet_288();
        Sum += Sub_Funclet_289();
        Sum += Sub_Funclet_290();
        Sum += Sub_Funclet_291();
        Sum += Sub_Funclet_292();
        Sum += Sub_Funclet_293();
        Sum += Sub_Funclet_294();
        Sum += Sub_Funclet_295();
        Sum += Sub_Funclet_296();
        Sum += Sub_Funclet_297();
        Sum += Sub_Funclet_298();
        Sum += Sub_Funclet_299();
        Sum += Sub_Funclet_300();
        Sum += Sub_Funclet_301();
        Sum += Sub_Funclet_302();
        Sum += Sub_Funclet_303();
        Sum += Sub_Funclet_304();
        Sum += Sub_Funclet_305();
        Sum += Sub_Funclet_306();
        Sum += Sub_Funclet_307();
        Sum += Sub_Funclet_308();
        Sum += Sub_Funclet_309();
        Sum += Sub_Funclet_310();
        Sum += Sub_Funclet_311();
        Sum += Sub_Funclet_312();
        Sum += Sub_Funclet_313();
        Sum += Sub_Funclet_314();
        Sum += Sub_Funclet_315();
        Sum += Sub_Funclet_316();
        Sum += Sub_Funclet_317();
        Sum += Sub_Funclet_318();
        Sum += Sub_Funclet_319();
        Sum += Sub_Funclet_320();
        Sum += Sub_Funclet_321();
        Sum += Sub_Funclet_322();
        Sum += Sub_Funclet_323();
        Sum += Sub_Funclet_324();
        Sum += Sub_Funclet_325();
        Sum += Sub_Funclet_326();
        Sum += Sub_Funclet_327();
        Sum += Sub_Funclet_328();
        Sum += Sub_Funclet_329();
        Sum += Sub_Funclet_330();
        Sum += Sub_Funclet_331();
        Sum += Sub_Funclet_332();
        Sum += Sub_Funclet_333();
        Sum += Sub_Funclet_334();
        Sum += Sub_Funclet_335();
        Sum += Sub_Funclet_336();
        Sum += Sub_Funclet_337();
        Sum += Sub_Funclet_338();
        Sum += Sub_Funclet_339();
        Sum += Sub_Funclet_340();
        Sum += Sub_Funclet_341();
        Sum += Sub_Funclet_342();
        Sum += Sub_Funclet_343();
        Sum += Sub_Funclet_344();
        Sum += Sub_Funclet_345();
        Sum += Sub_Funclet_346();
        Sum += Sub_Funclet_347();
        Sum += Sub_Funclet_348();
        Sum += Sub_Funclet_349();
        Sum += Sub_Funclet_350();
        Sum += Sub_Funclet_351();
        Sum += Sub_Funclet_352();
        Sum += Sub_Funclet_353();
        Sum += Sub_Funclet_354();
        Sum += Sub_Funclet_355();
        Sum += Sub_Funclet_356();
        Sum += Sub_Funclet_357();
        Sum += Sub_Funclet_358();
        Sum += Sub_Funclet_359();
        Sum += Sub_Funclet_360();
        Sum += Sub_Funclet_361();
        Sum += Sub_Funclet_362();
        Sum += Sub_Funclet_363();
        Sum += Sub_Funclet_364();
        Sum += Sub_Funclet_365();
        Sum += Sub_Funclet_366();
        Sum += Sub_Funclet_367();
        Sum += Sub_Funclet_368();
        Sum += Sub_Funclet_369();
        Sum += Sub_Funclet_370();
        Sum += Sub_Funclet_371();
        Sum += Sub_Funclet_372();
        Sum += Sub_Funclet_373();
        Sum += Sub_Funclet_374();
        Sum += Sub_Funclet_375();
        Sum += Sub_Funclet_376();
        Sum += Sub_Funclet_377();
        Sum += Sub_Funclet_378();
        Sum += Sub_Funclet_379();
        Sum += Sub_Funclet_380();
        Sum += Sub_Funclet_381();
        Sum += Sub_Funclet_382();
        Sum += Sub_Funclet_383();
        Sum += Sub_Funclet_384();
        Sum += Sub_Funclet_385();
        Sum += Sub_Funclet_386();
        Sum += Sub_Funclet_387();
        Sum += Sub_Funclet_388();
        Sum += Sub_Funclet_389();
        Sum += Sub_Funclet_390();
        Sum += Sub_Funclet_391();
        Sum += Sub_Funclet_392();
        Sum += Sub_Funclet_393();
        Sum += Sub_Funclet_394();
        Sum += Sub_Funclet_395();
        Sum += Sub_Funclet_396();
        Sum += Sub_Funclet_397();
        Sum += Sub_Funclet_398();
        Sum += Sub_Funclet_399();
        Sum += Sub_Funclet_400();
        Sum += Sub_Funclet_401();
        Sum += Sub_Funclet_402();
        Sum += Sub_Funclet_403();
        Sum += Sub_Funclet_404();
        Sum += Sub_Funclet_405();
        Sum += Sub_Funclet_406();
        Sum += Sub_Funclet_407();
        Sum += Sub_Funclet_408();
        Sum += Sub_Funclet_409();
        Sum += Sub_Funclet_410();
        Sum += Sub_Funclet_411();
        Sum += Sub_Funclet_412();
        Sum += Sub_Funclet_413();
        Sum += Sub_Funclet_414();
        Sum += Sub_Funclet_415();
        Sum += Sub_Funclet_416();
        Sum += Sub_Funclet_417();
        Sum += Sub_Funclet_418();
        Sum += Sub_Funclet_419();
        Sum += Sub_Funclet_420();
        Sum += Sub_Funclet_421();
        Sum += Sub_Funclet_422();
        Sum += Sub_Funclet_423();
        Sum += Sub_Funclet_424();
        Sum += Sub_Funclet_425();
        Sum += Sub_Funclet_426();
        Sum += Sub_Funclet_427();
        Sum += Sub_Funclet_428();
        Sum += Sub_Funclet_429();
        Sum += Sub_Funclet_430();
        Sum += Sub_Funclet_431();
        Sum += Sub_Funclet_432();
        Sum += Sub_Funclet_433();
        Sum += Sub_Funclet_434();
        Sum += Sub_Funclet_435();
        Sum += Sub_Funclet_436();
        Sum += Sub_Funclet_437();
        Sum += Sub_Funclet_438();
        Sum += Sub_Funclet_439();
        Sum += Sub_Funclet_440();
        Sum += Sub_Funclet_441();
        Sum += Sub_Funclet_442();
        Sum += Sub_Funclet_443();
        Sum += Sub_Funclet_444();
        Sum += Sub_Funclet_445();
        Sum += Sub_Funclet_446();
        Sum += Sub_Funclet_447();
        Sum += Sub_Funclet_448();
        Sum += Sub_Funclet_449();
        Sum += Sub_Funclet_450();
        Sum += Sub_Funclet_451();
        Sum += Sub_Funclet_452();
        Sum += Sub_Funclet_453();
        Sum += Sub_Funclet_454();
        Sum += Sub_Funclet_455();
        Sum += Sub_Funclet_456();
        Sum += Sub_Funclet_457();
        Sum += Sub_Funclet_458();
        Sum += Sub_Funclet_459();
        Sum += Sub_Funclet_460();

        if ((Sum > -3032.5) && (Sum < -3031.5))
        {
            Console.WriteLine("PASSED");
            return 100;
        }
        else
        {
            Console.WriteLine("FAILED");
            return 1;
        }
    }
}
