namespace Corsair.CUE.SDK
{
    /// <summary>
    /// Contains shared list of all leds on all devices (keyboard, mouse, mouse mat, headset, headset stand, DIY, memory module, cooler) and all models/physical layouts.
    /// </summary>
    public enum CorsairLedId
    {
        /// <summary>
        /// Dummy value
        /// </summary>
        CLI_Invalid = 0,

        /// <summary>
        /// For keyboard escape led
        /// </summary>
        CLK_Escape = 1,

        /// <summary>
        /// For keyboard F1 led
        /// </summary>
        CLK_F1 = 2,

        /// <summary>
        /// For keyboard F2 led
        /// </summary>
        CLK_F2 = 3,

        /// <summary>
        /// For keyboard F3 led
        /// </summary>
        CLK_F3 = 4,

        /// <summary>
        /// For keyboard F4 led
        /// </summary>
        CLK_F4 = 5,

        /// <summary>
        /// For keyboard F5 led
        /// </summary>
        CLK_F5 = 6,

        /// <summary>
        /// For keyboard F6 led
        /// </summary>
        CLK_F6 = 7,

        /// <summary>
        /// For keyboard F7 led
        /// </summary>
        CLK_F7 = 8,

        /// <summary>
        /// For keyboard F8 led
        /// </summary>
        CLK_F8 = 9,

        /// <summary>
        /// For keyboard F9 led
        /// </summary>
        CLK_F9 = 10,

        /// <summary>
        /// For keyboard F10 led
        /// </summary>
        CLK_F10 = 11,

        /// <summary>
        /// For keyboard F11 led
        /// </summary>
        CLK_F11 = 12,

        /// <summary>
        /// For keyboard grave accent and tilde led
        /// </summary>
        CLK_GraveAccentAndTilde = 13,

        /// <summary>
        /// For keyboard 1 led
        /// </summary>
        CLK_1 = 14,

        /// <summary>
        /// For keyboard 2 led
        /// </summary>
        CLK_2 = 15,

        /// <summary>
        /// For keyboard 3 led
        /// </summary>
        CLK_3 = 16,

        /// <summary>
        /// For keyboard 4 led
        /// </summary>
        CLK_4 = 17,

        /// <summary>
        /// For keyboard 5 led
        /// </summary>
        CLK_5 = 18,

        /// <summary>
        /// For keyboard 6 led
        /// </summary>
        CLK_6 = 19,

        /// <summary>
        /// For keyboard 7 led
        /// </summary>
        CLK_7 = 20,

        /// <summary>
        /// For keyboard 8 led
        /// </summary>
        CLK_8 = 21,

        /// <summary>
        /// For keyboard 9 led
        /// </summary>
        CLK_9 = 22,

        /// <summary>
        /// For keyboard 0 led
        /// </summary>
        CLK_0 = 23,

        /// <summary>
        /// For keyboard minus and underscore led
        /// </summary>
        CLK_MinusAndUnderscore = 24,

        /// <summary>
        /// For keyboard tab led
        /// </summary>
        CLK_Tab = 25,

        /// <summary>
        /// For keyboard q led
        /// </summary>
        CLK_Q = 26,

        /// <summary>
        /// For keyboard w led
        /// </summary>
        CLK_W = 27,

        /// <summary>
        /// For keyboard e led
        /// </summary>
        CLK_E = 28,

        /// <summary>
        /// For keyboard r led
        /// </summary>
        CLK_R = 29,

        /// <summary>
        /// For keyboard t led
        /// </summary>
        CLK_T = 30,

        /// <summary>
        /// For keyboard y led
        /// </summary>
        CLK_Y = 31,

        /// <summary>
        /// For keyboard u led
        /// </summary>
        CLK_U = 32,

        /// <summary>
        /// For keyboard i led
        /// </summary>
        CLK_I = 33,

        /// <summary>
        /// For keyboard o led
        /// </summary>
        CLK_O = 34,

        /// <summary>
        /// For keyboard p led
        /// </summary>
        CLK_P = 35,

        /// <summary>
        /// For keyboard bracket(left) led
        /// </summary>
        CLK_BracketLeft = 36,

        /// <summary>
        /// For keyboard caps lock led
        /// </summary>
        CLK_CapsLock = 37,

        /// <summary>
        /// For keyboard a led
        /// </summary>
        CLK_A = 38,

        /// <summary>
        /// For keyboard s led
        /// </summary>
        CLK_S = 39,

        /// <summary>
        /// For keyboard d led
        /// </summary>
        CLK_D = 40,

        /// <summary>
        /// For keyboard f led
        /// </summary>
        CLK_F = 41,

        /// <summary>
        /// For keyboard g led
        /// </summary>
        CLK_G = 42,

        /// <summary>
        /// For keyboard h led
        /// </summary>
        CLK_H = 43,

        /// <summary>
        /// For keyboard j led
        /// </summary>
        CLK_J = 44,

        /// <summary>
        /// For keyboard k led
        /// </summary>
        CLK_K = 45,

        /// <summary>
        /// For keyboard l led
        /// </summary>
        CLK_L = 46,

        /// <summary>
        /// For keyboard semicolon and colon led
        /// </summary>
        CLK_SemicolonAndColon = 47,

        /// <summary>
        /// For keyboard apostrophe and double quote led
        /// </summary>
        CLK_ApostropheAndDoubleQuote = 48,

        /// <summary>
        /// For keyboard left shift led
        /// </summary>
        CLK_LeftShift = 49,

        /// <summary>
        /// For keyboard non-US backslash led
        /// </summary>
        CLK_NonUsBackslash = 50,

        /// <summary>
        /// For keyboard z led
        /// </summary>
        CLK_Z = 51,

        /// <summary>
        /// For keyboard x led
        /// </summary>
        CLK_X = 52,

        /// <summary>
        /// For keyboard c led
        /// </summary>
        CLK_C = 53,

        /// <summary>
        /// For keyboard v led
        /// </summary>
        CLK_V = 54,

        /// <summary>
        /// For keyboard b led
        /// </summary>
        CLK_B = 55,

        /// <summary>
        /// For keyboard n led
        /// </summary>
        CLK_N = 56,

        /// <summary>
        /// For keyboard m led
        /// </summary>
        CLK_M = 57,

        /// <summary>
        /// For keyboard comma and less than led
        /// </summary>
        CLK_CommaAndLessThan = 58,

        /// <summary>
        /// For keyboard period and Bigger than led
        /// </summary>
        CLK_PeriodAndBiggerThan = 59,

        /// <summary>
        /// For keyboard slash and question mark led
        /// </summary>
        CLK_SlashAndQuestionMark = 60,

        /// <summary>
        /// For keyboard left ctrl led
        /// </summary>
        CLK_LeftCtrl = 61,

        /// <summary>
        /// For keyboard left gui led
        /// </summary>
        CLK_LeftGui = 62,

        /// <summary>
        /// For keyboard left alt led
        /// </summary>
        CLK_LeftAlt = 63,

        /// <summary>
        /// For keyboard lang 2 led
        /// </summary>
        CLK_Lang2 = 64,

        /// <summary>
        /// For keyboard space led
        /// </summary>
        CLK_Space = 65,

        /// <summary>
        /// For keyboard lang 1 led
        /// </summary>
        CLK_Lang1 = 66,

        /// <summary>
        /// For keyboard international 2 led
        /// </summary>
        CLK_International2 = 67,

        /// <summary>
        /// For keyboard right alt led
        /// </summary>
        CLK_RightAlt = 68,

        /// <summary>
        /// For keyboard right gui led
        /// </summary>
        CLK_RightGui = 69,

        /// <summary>
        /// For keyboard application led
        /// </summary>
        CLK_Application = 70,

        /// <summary>
        /// For keyboard led programming led
        /// </summary>
        CLK_LedProgramming = 71,

        /// <summary>
        /// For keyboard brightness led
        /// </summary>
        CLK_Brightness = 72,

        /// <summary>
        /// For keyboard F12 led
        /// </summary>
        CLK_F12 = 73,

        /// <summary>
        /// For keyboard print screen led
        /// </summary>
        CLK_PrintScreen = 74,

        /// <summary>
        /// For keyboard scroll lock led
        /// </summary>
        CLK_ScrollLock = 75,

        /// <summary>
        /// For keyboard pause break led
        /// </summary>
        CLK_PauseBreak = 76,

        /// <summary>
        /// For keyboard insert led
        /// </summary>
        CLK_Insert = 77,

        /// <summary>
        /// For keyboard home led
        /// </summary>
        CLK_Home = 78,

        /// <summary>
        /// For keyboard page up led
        /// </summary>
        CLK_PageUp = 79,

        /// <summary>
        /// For keyboard bracket(right) led
        /// </summary>
        CLK_BracketRight = 80,

        /// <summary>
        /// For keyboard backslash led
        /// </summary>
        CLK_Backslash = 81,

        /// <summary>
        /// For keyboard non-US tilde led
        /// </summary>
        CLK_NonUsTilde = 82,

        /// <summary>
        /// For keyboard enter led
        /// </summary>
        CLK_Enter = 83,

        /// <summary>
        /// For keyboard international 1 led
        /// </summary>
        CLK_International1 = 84,

        /// <summary>
        /// For keyboard equals and plus led
        /// </summary>
        CLK_EqualsAndPlus = 85,

        /// <summary>
        /// For keyboard international 3 led
        /// </summary>
        CLK_International3 = 86,

        /// <summary>
        /// For keyboard backspace led
        /// </summary>
        CLK_Backspace = 87,

        /// <summary>
        /// For keyboard delete led
        /// </summary>
        CLK_Delete = 88,

        /// <summary>
        /// For keyboard end led
        /// </summary>
        CLK_End = 89,

        /// <summary>
        /// For keyboard page down led
        /// </summary>
        CLK_PageDown = 90,

        /// <summary>
        /// For keyboard right shift led
        /// </summary>
        CLK_RightShift = 91,

        /// <summary>
        /// For keyboard right ctrl led
        /// </summary>
        CLK_RightCtrl = 92,

        /// <summary>
        /// For keyboard up arrow led
        /// </summary>
        CLK_UpArrow = 93,

        /// <summary>
        /// For keyboard left arrow led
        /// </summary>
        CLK_LeftArrow = 94,

        /// <summary>
        /// For keyboard down arrow led
        /// </summary>
        CLK_DownArrow = 95,

        /// <summary>
        /// For keyboard right arrow led
        /// </summary>
        CLK_RightArrow = 96,

        /// <summary>
        /// For keyboard win lock led
        /// </summary>
        CLK_WinLock = 97,

        /// <summary>
        /// For keyboard mute led
        /// </summary>
        CLK_Mute = 98,

        /// <summary>
        /// For keyboard stop led
        /// </summary>
        CLK_Stop = 99,

        /// <summary>
        /// For keyboard scan previous track led
        /// </summary>
        CLK_ScanPreviousTrack = 100,

        /// <summary>
        /// For keyboard play/pause led
        /// </summary>
        CLK_PlayPause = 101,

        /// <summary>
        /// For keyboard scan next track led
        /// </summary>
        CLK_ScanNextTrack = 102,

        /// <summary>
        /// For keyboard num lock led
        /// </summary>
        CLK_NumLock = 103,

        /// <summary>
        /// For keyboard keypad slash led
        /// </summary>
        CLK_KeypadSlash = 104,

        /// <summary>
        /// For keyboard keypad asterisk led
        /// </summary>
        CLK_KeypadAsterisk = 105,

        /// <summary>
        /// For keyboard keypad minus led
        /// </summary>
        CLK_KeypadMinus = 106,

        /// <summary>
        /// For keyboard keypad plus led
        /// </summary>
        CLK_KeypadPlus = 107,

        /// <summary>
        /// For keyboard keypad enter led
        /// </summary>
        CLK_KeypadEnter = 108,

        /// <summary>
        /// For keyboard keypad 7 led
        /// </summary>
        CLK_Keypad7 = 109,

        /// <summary>
        /// For keyboard keypad 8 led
        /// </summary>
        CLK_Keypad8 = 110,

        /// <summary>
        /// For keyboard keypad 9 led
        /// </summary>
        CLK_Keypad9 = 111,

        /// <summary>
        /// For keyboard keypad comma led
        /// </summary>
        CLK_KeypadComma = 112,

        /// <summary>
        /// For keyboard keypad 4 led
        /// </summary>
        CLK_Keypad4 = 113,

        /// <summary>
        /// For keyboard keypad 5 led
        /// </summary>
        CLK_Keypad5 = 114,

        /// <summary>
        /// For keyboard keypad 6 led
        /// </summary>
        CLK_Keypad6 = 115,

        /// <summary>
        /// For keyboard keypad 1 led
        /// </summary>
        CLK_Keypad1 = 116,

        /// <summary>
        /// For keyboard keypad 2 led
        /// </summary>
        CLK_Keypad2 = 117,

        /// <summary>
        /// For keyboard keypad 3 led
        /// </summary>
        CLK_Keypad3 = 118,

        /// <summary>
        /// For keyboard keypad 0 led
        /// </summary>
        CLK_Keypad0 = 119,

        /// <summary>
        /// For keyboard keypad period and delete led
        /// </summary>
        CLK_KeypadPeriodAndDelete = 120,

        /// <summary>
        /// For keyboard G1 led
        /// </summary>
        CLK_G1 = 121,

        /// <summary>
        /// For keyboard G2 led
        /// </summary>
        CLK_G2 = 122,

        /// <summary>
        /// For keyboard G3 led
        /// </summary>
        CLK_G3 = 123,

        /// <summary>
        /// For keyboard G4 led
        /// </summary>
        CLK_G4 = 124,

        /// <summary>
        /// For keyboard G5 led
        /// </summary>
        CLK_G5 = 125,

        /// <summary>
        /// For keyboard G6 led
        /// </summary>
        CLK_G6 = 126,

        /// <summary>
        /// For keyboard G7 led
        /// </summary>
        CLK_G7 = 127,

        /// <summary>
        /// For keyboard G8 led
        /// </summary>
        CLK_G8 = 128,

        /// <summary>
        /// For keyboard G9 led
        /// </summary>
        CLK_G9 = 129,

        /// <summary>
        /// For keyboard G10 led
        /// </summary>
        CLK_G10 = 130,

        /// <summary>
        /// For keyboard volume up led
        /// </summary>
        CLK_VolumeUp = 131,

        /// <summary>
        /// For keyboard volume down led
        /// </summary>
        CLK_VolumeDown = 132,

        /// <summary>
        /// For keyboard MR led
        /// </summary>
        CLK_MR = 133,

        /// <summary>
        /// For keyboard M1 led
        /// </summary>
        CLK_M1 = 134,

        /// <summary>
        /// For keyboard M2 led
        /// </summary>
        CLK_M2 = 135,

        /// <summary>
        /// For keyboard M3 led
        /// </summary>
        CLK_M3 = 136,

        /// <summary>
        /// For keyboard G11 led
        /// </summary>
        CLK_G11 = 137,

        /// <summary>
        /// For keyboard G12 led
        /// </summary>
        CLK_G12 = 138,

        /// <summary>
        /// For keyboard G13 led
        /// </summary>
        CLK_G13 = 139,

        /// <summary>
        /// For keyboard G14 led
        /// </summary>
        CLK_G14 = 140,

        /// <summary>
        /// For keyboard G15 led
        /// </summary>
        CLK_G15 = 141,

        /// <summary>
        /// For keyboard G16 led
        /// </summary>
        CLK_G16 = 142,

        /// <summary>
        /// For keyboard G17 led
        /// </summary>
        CLK_G17 = 143,

        /// <summary>
        /// For keyboard G18 led
        /// </summary>
        CLK_G18 = 144,

        /// <summary>
        /// For keyboard international 5 led
        /// </summary>
        CLK_International5 = 145,

        /// <summary>
        /// For keyboard international 4 led
        /// </summary>
        CLK_International4 = 146,

        /// <summary>
        /// For keyboard fn led
        /// </summary>
        CLK_Fn = 147,

        /// <summary>
        /// For mouse 1 led
        /// </summary>
        CLM_1 = 148,

        /// <summary>
        /// For mouse 2 led
        /// </summary>
        CLM_2 = 149,

        /// <summary>
        /// For mouse 3 led
        /// </summary>
        CLM_3 = 150,

        /// <summary>
        /// For mouse 4 led
        /// </summary>
        CLM_4 = 151,

        /// <summary>
        /// For headset left logo led
        /// </summary>
        CLH_LeftLogo = 152,

        /// <summary>
        /// For headset right logo led
        /// </summary>
        CLH_RightLogo = 153,

        /// <summary>
        /// For keyboard logo led
        /// </summary>
        CLK_Logo = 154,

        /// <summary>
        /// For mousemat zone 1 led
        /// </summary>
        CLMM_Zone1 = 155,

        /// <summary>
        /// For mousemat zone 2 led
        /// </summary>
        CLMM_Zone2 = 156,

        /// <summary>
        /// For mousemat zone 3 led
        /// </summary>
        CLMM_Zone3 = 157,

        /// <summary>
        /// For mousemat zone 4 led
        /// </summary>
        CLMM_Zone4 = 158,

        /// <summary>
        /// For mousemat zone 5 led
        /// </summary>
        CLMM_Zone5 = 159,

        /// <summary>
        /// For mousemat zone 6 led
        /// </summary>
        CLMM_Zone6 = 160,

        /// <summary>
        /// For mousemat zone 7 led
        /// </summary>
        CLMM_Zone7 = 161,

        /// <summary>
        /// For mousemat zone 8 led
        /// </summary>
        CLMM_Zone8 = 162,

        /// <summary>
        /// For mousemat zone 9 led
        /// </summary>
        CLMM_Zone9 = 163,

        /// <summary>
        /// For mousemat zone 10 led
        /// </summary>
        CLMM_Zone10 = 164,

        /// <summary>
        /// For mousemat zone 11 led
        /// </summary>
        CLMM_Zone11 = 165,

        /// <summary>
        /// For mousemat zone 12 led
        /// </summary>
        CLMM_Zone12 = 166,

        /// <summary>
        /// For mousemat zone 13 led
        /// </summary>
        CLMM_Zone13 = 167,

        /// <summary>
        /// For mousemat zone 14 led
        /// </summary>
        CLMM_Zone14 = 168,

        /// <summary>
        /// For mousemat zone 15 led
        /// </summary>
        CLMM_Zone15 = 169,

        /// <summary>
        /// For keyboard light pipe zone 1 led
        /// </summary>
        CLKLP_Zone1 = 170,

        /// <summary>
        /// For keyboard light pipe zone 2 led
        /// </summary>
        CLKLP_Zone2 = 171,

        /// <summary>
        /// For keyboard light pipe zone 3 led
        /// </summary>
        CLKLP_Zone3 = 172,

        /// <summary>
        /// For keyboard light pipe zone 4 led
        /// </summary>
        CLKLP_Zone4 = 173,

        /// <summary>
        /// For keyboard light pipe zone 5 led
        /// </summary>
        CLKLP_Zone5 = 174,

        /// <summary>
        /// For keyboard light pipe zone 6 led
        /// </summary>
        CLKLP_Zone6 = 175,

        /// <summary>
        /// For keyboard light pipe zone 7 led
        /// </summary>
        CLKLP_Zone7 = 176,

        /// <summary>
        /// For keyboard light pipe zone 8 led
        /// </summary>
        CLKLP_Zone8 = 177,

        /// <summary>
        /// For keyboard light pipe zone 9 led
        /// </summary>
        CLKLP_Zone9 = 178,

        /// <summary>
        /// For keyboard light pipe zone 10 led
        /// </summary>
        CLKLP_Zone10 = 179,

        /// <summary>
        /// For keyboard light pipe zone 11 led
        /// </summary>
        CLKLP_Zone11 = 180,

        /// <summary>
        /// For keyboard light pipe zone 12 led
        /// </summary>
        CLKLP_Zone12 = 181,

        /// <summary>
        /// For keyboard light pipe zone 13 led
        /// </summary>
        CLKLP_Zone13 = 182,

        /// <summary>
        /// For keyboard light pipe zone 14 led
        /// </summary>
        CLKLP_Zone14 = 183,

        /// <summary>
        /// For keyboard light pipe zone 15 led
        /// </summary>
        CLKLP_Zone15 = 184,

        /// <summary>
        /// For keyboard light pipe zone 16 led
        /// </summary>
        CLKLP_Zone16 = 185,

        /// <summary>
        /// For keyboard light pipe zone 17 led
        /// </summary>
        CLKLP_Zone17 = 186,

        /// <summary>
        /// For keyboard light pipe zone 18 led
        /// </summary>
        CLKLP_Zone18 = 187,

        /// <summary>
        /// For keyboard light pipe zone 19 led
        /// </summary>
        CLKLP_Zone19 = 188,

        /// <summary>
        /// For mouse 5 led
        /// </summary>
        CLM_5 = 189,

        /// <summary>
        /// For mouse 6 led
        /// </summary>
        CLM_6 = 190,

        /// <summary>
        /// For headset stand zone 1 led
        /// </summary>
        CLHSS_Zone1 = 191,

        /// <summary>
        /// For headset stand zone 2 led
        /// </summary>
        CLHSS_Zone2 = 192,

        /// <summary>
        /// For headset stand zone 3 led
        /// </summary>
        CLHSS_Zone3 = 193,

        /// <summary>
        /// For headset stand zone 4 led
        /// </summary>
        CLHSS_Zone4 = 194,

        /// <summary>
        /// For headset stand zone 5 led
        /// </summary>
        CLHSS_Zone5 = 195,

        /// <summary>
        /// For headset stand zone 6 led
        /// </summary>
        CLHSS_Zone6 = 196,

        /// <summary>
        /// For headset stand zone 7 led
        /// </summary>
        CLHSS_Zone7 = 197,

        /// <summary>
        /// For headset stand zone 8 led
        /// </summary>
        CLHSS_Zone8 = 198,

        /// <summary>
        /// For headset stand zone 9 led
        /// </summary>
        CLHSS_Zone9 = 199,

        /// <summary>
        /// For first channel of the DIY-devices led 1
        /// </summary>
        CLD_C1_1 = 200,

        /// <summary>
        /// For first channel of the DIY-devices led 2
        /// </summary>
        CLD_C1_2 = 201,

        /// <summary>
        /// For first channel of the DIY-devices led 3
        /// </summary>
        CLD_C1_3 = 202,

        /// <summary>
        /// For first channel of the DIY-devices led 4
        /// </summary>
        CLD_C1_4 = 203,

        /// <summary>
        /// For first channel of the DIY-devices led 5
        /// </summary>
        CLD_C1_5 = 204,

        /// <summary>
        /// For first channel of the DIY-devices led 6
        /// </summary>
        CLD_C1_6 = 205,

        /// <summary>
        /// For first channel of the DIY-devices led 7
        /// </summary>
        CLD_C1_7 = 206,

        /// <summary>
        /// For first channel of the DIY-devices led 8
        /// </summary>
        CLD_C1_8 = 207,

        /// <summary>
        /// For first channel of the DIY-devices led 9
        /// </summary>
        CLD_C1_9 = 208,

        /// <summary>
        /// For first channel of the DIY-devices led 10
        /// </summary>
        CLD_C1_10 = 209,

        /// <summary>
        /// For first channel of the DIY-devices led 11
        /// </summary>
        CLD_C1_11 = 210,

        /// <summary>
        /// For first channel of the DIY-devices led 12
        /// </summary>
        CLD_C1_12 = 211,

        /// <summary>
        /// For first channel of the DIY-devices led 13
        /// </summary>
        CLD_C1_13 = 212,

        /// <summary>
        /// For first channel of the DIY-devices led 14
        /// </summary>
        CLD_C1_14 = 213,

        /// <summary>
        /// For first channel of the DIY-devices led 15
        /// </summary>
        CLD_C1_15 = 214,

        /// <summary>
        /// For first channel of the DIY-devices led 16
        /// </summary>
        CLD_C1_16 = 215,

        /// <summary>
        /// For first channel of the DIY-devices led 17
        /// </summary>
        CLD_C1_17 = 216,

        /// <summary>
        /// For first channel of the DIY-devices led 18
        /// </summary>
        CLD_C1_18 = 217,

        /// <summary>
        /// For first channel of the DIY-devices led 19
        /// </summary>
        CLD_C1_19 = 218,

        /// <summary>
        /// For first channel of the DIY-devices led 20
        /// </summary>
        CLD_C1_20 = 219,

        /// <summary>
        /// For first channel of the DIY-devices led 21
        /// </summary>
        CLD_C1_21 = 220,

        /// <summary>
        /// For first channel of the DIY-devices led 22
        /// </summary>
        CLD_C1_22 = 221,

        /// <summary>
        /// For first channel of the DIY-devices led 23
        /// </summary>
        CLD_C1_23 = 222,

        /// <summary>
        /// For first channel of the DIY-devices led 24
        /// </summary>
        CLD_C1_24 = 223,

        /// <summary>
        /// For first channel of the DIY-devices led 25
        /// </summary>
        CLD_C1_25 = 224,

        /// <summary>
        /// For first channel of the DIY-devices led 26
        /// </summary>
        CLD_C1_26 = 225,

        /// <summary>
        /// For first channel of the DIY-devices led 27
        /// </summary>
        CLD_C1_27 = 226,

        /// <summary>
        /// For first channel of the DIY-devices led 28
        /// </summary>
        CLD_C1_28 = 227,

        /// <summary>
        /// For first channel of the DIY-devices led 29
        /// </summary>
        CLD_C1_29 = 228,

        /// <summary>
        /// For first channel of the DIY-devices led 30
        /// </summary>
        CLD_C1_30 = 229,

        /// <summary>
        /// For first channel of the DIY-devices led 31
        /// </summary>
        CLD_C1_31 = 230,

        /// <summary>
        /// For first channel of the DIY-devices led 32
        /// </summary>
        CLD_C1_32 = 231,

        /// <summary>
        /// For first channel of the DIY-devices led 33
        /// </summary>
        CLD_C1_33 = 232,

        /// <summary>
        /// For first channel of the DIY-devices led 34
        /// </summary>
        CLD_C1_34 = 233,

        /// <summary>
        /// For first channel of the DIY-devices led 35
        /// </summary>
        CLD_C1_35 = 234,

        /// <summary>
        /// For first channel of the DIY-devices led 36
        /// </summary>
        CLD_C1_36 = 235,

        /// <summary>
        /// For first channel of the DIY-devices led 37
        /// </summary>
        CLD_C1_37 = 236,

        /// <summary>
        /// For first channel of the DIY-devices led 38
        /// </summary>
        CLD_C1_38 = 237,

        /// <summary>
        /// For first channel of the DIY-devices led 39
        /// </summary>
        CLD_C1_39 = 238,

        /// <summary>
        /// For first channel of the DIY-devices led 40
        /// </summary>
        CLD_C1_40 = 239,

        /// <summary>
        /// For first channel of the DIY-devices led 41
        /// </summary>
        CLD_C1_41 = 240,

        /// <summary>
        /// For first channel of the DIY-devices led 42
        /// </summary>
        CLD_C1_42 = 241,

        /// <summary>
        /// For first channel of the DIY-devices led 43
        /// </summary>
        CLD_C1_43 = 242,

        /// <summary>
        /// For first channel of the DIY-devices led 44
        /// </summary>
        CLD_C1_44 = 243,

        /// <summary>
        /// For first channel of the DIY-devices led 45
        /// </summary>
        CLD_C1_45 = 244,

        /// <summary>
        /// For first channel of the DIY-devices led 46
        /// </summary>
        CLD_C1_46 = 245,

        /// <summary>
        /// For first channel of the DIY-devices led 47
        /// </summary>
        CLD_C1_47 = 246,

        /// <summary>
        /// For first channel of the DIY-devices led 48
        /// </summary>
        CLD_C1_48 = 247,

        /// <summary>
        /// For first channel of the DIY-devices led 49
        /// </summary>
        CLD_C1_49 = 248,

        /// <summary>
        /// For first channel of the DIY-devices led 50
        /// </summary>
        CLD_C1_50 = 249,

        /// <summary>
        /// For first channel of the DIY-devices led 51
        /// </summary>
        CLD_C1_51 = 250,

        /// <summary>
        /// For first channel of the DIY-devices led 52
        /// </summary>
        CLD_C1_52 = 251,

        /// <summary>
        /// For first channel of the DIY-devices led 53
        /// </summary>
        CLD_C1_53 = 252,

        /// <summary>
        /// For first channel of the DIY-devices led 54
        /// </summary>
        CLD_C1_54 = 253,

        /// <summary>
        /// For first channel of the DIY-devices led 55
        /// </summary>
        CLD_C1_55 = 254,

        /// <summary>
        /// For first channel of the DIY-devices led 56
        /// </summary>
        CLD_C1_56 = 255,

        /// <summary>
        /// For first channel of the DIY-devices led 57
        /// </summary>
        CLD_C1_57 = 256,

        /// <summary>
        /// For first channel of the DIY-devices led 58
        /// </summary>
        CLD_C1_58 = 257,

        /// <summary>
        /// For first channel of the DIY-devices led 59
        /// </summary>
        CLD_C1_59 = 258,

        /// <summary>
        /// For first channel of the DIY-devices led 60
        /// </summary>
        CLD_C1_60 = 259,

        /// <summary>
        /// For first channel of the DIY-devices led 61
        /// </summary>
        CLD_C1_61 = 260,

        /// <summary>
        /// For first channel of the DIY-devices led 62
        /// </summary>
        CLD_C1_62 = 261,

        /// <summary>
        /// For first channel of the DIY-devices led 63
        /// </summary>
        CLD_C1_63 = 262,

        /// <summary>
        /// For first channel of the DIY-devices led 64
        /// </summary>
        CLD_C1_64 = 263,

        /// <summary>
        /// For first channel of the DIY-devices led 65
        /// </summary>
        CLD_C1_65 = 264,

        /// <summary>
        /// For first channel of the DIY-devices led 66
        /// </summary>
        CLD_C1_66 = 265,

        /// <summary>
        /// For first channel of the DIY-devices led 67
        /// </summary>
        CLD_C1_67 = 266,

        /// <summary>
        /// For first channel of the DIY-devices led 68
        /// </summary>
        CLD_C1_68 = 267,

        /// <summary>
        /// For first channel of the DIY-devices led 69
        /// </summary>
        CLD_C1_69 = 268,

        /// <summary>
        /// For first channel of the DIY-devices led 70
        /// </summary>
        CLD_C1_70 = 269,

        /// <summary>
        /// For first channel of the DIY-devices led 71
        /// </summary>
        CLD_C1_71 = 270,

        /// <summary>
        /// For first channel of the DIY-devices led 72
        /// </summary>
        CLD_C1_72 = 271,

        /// <summary>
        /// For first channel of the DIY-devices led 73
        /// </summary>
        CLD_C1_73 = 272,

        /// <summary>
        /// For first channel of the DIY-devices led 74
        /// </summary>
        CLD_C1_74 = 273,

        /// <summary>
        /// For first channel of the DIY-devices led 75
        /// </summary>
        CLD_C1_75 = 274,

        /// <summary>
        /// For first channel of the DIY-devices led 76
        /// </summary>
        CLD_C1_76 = 275,

        /// <summary>
        /// For first channel of the DIY-devices led 77
        /// </summary>
        CLD_C1_77 = 276,

        /// <summary>
        /// For first channel of the DIY-devices led 78
        /// </summary>
        CLD_C1_78 = 277,

        /// <summary>
        /// For first channel of the DIY-devices led 79
        /// </summary>
        CLD_C1_79 = 278,

        /// <summary>
        /// For first channel of the DIY-devices led 80
        /// </summary>
        CLD_C1_80 = 279,

        /// <summary>
        /// For first channel of the DIY-devices led 81
        /// </summary>
        CLD_C1_81 = 280,

        /// <summary>
        /// For first channel of the DIY-devices led 82
        /// </summary>
        CLD_C1_82 = 281,

        /// <summary>
        /// For first channel of the DIY-devices led 83
        /// </summary>
        CLD_C1_83 = 282,

        /// <summary>
        /// For first channel of the DIY-devices led 84
        /// </summary>
        CLD_C1_84 = 283,

        /// <summary>
        /// For first channel of the DIY-devices led 85
        /// </summary>
        CLD_C1_85 = 284,

        /// <summary>
        /// For first channel of the DIY-devices led 86
        /// </summary>
        CLD_C1_86 = 285,

        /// <summary>
        /// For first channel of the DIY-devices led 87
        /// </summary>
        CLD_C1_87 = 286,

        /// <summary>
        /// For first channel of the DIY-devices led 88
        /// </summary>
        CLD_C1_88 = 287,

        /// <summary>
        /// For first channel of the DIY-devices led 89
        /// </summary>
        CLD_C1_89 = 288,

        /// <summary>
        /// For first channel of the DIY-devices led 90
        /// </summary>
        CLD_C1_90 = 289,

        /// <summary>
        /// For first channel of the DIY-devices led 91
        /// </summary>
        CLD_C1_91 = 290,

        /// <summary>
        /// For first channel of the DIY-devices led 92
        /// </summary>
        CLD_C1_92 = 291,

        /// <summary>
        /// For first channel of the DIY-devices led 93
        /// </summary>
        CLD_C1_93 = 292,

        /// <summary>
        /// For first channel of the DIY-devices led 94
        /// </summary>
        CLD_C1_94 = 293,

        /// <summary>
        /// For first channel of the DIY-devices led 95
        /// </summary>
        CLD_C1_95 = 294,

        /// <summary>
        /// For first channel of the DIY-devices led 96
        /// </summary>
        CLD_C1_96 = 295,

        /// <summary>
        /// For first channel of the DIY-devices led 97
        /// </summary>
        CLD_C1_97 = 296,

        /// <summary>
        /// For first channel of the DIY-devices led 98
        /// </summary>
        CLD_C1_98 = 297,

        /// <summary>
        /// For first channel of the DIY-devices led 99
        /// </summary>
        CLD_C1_99 = 298,

        /// <summary>
        /// For first channel of the DIY-devices led 100
        /// </summary>
        CLD_C1_100 = 299,

        /// <summary>
        /// For first channel of the DIY-devices led 101
        /// </summary>
        CLD_C1_101 = 300,

        /// <summary>
        /// For first channel of the DIY-devices led 102
        /// </summary>
        CLD_C1_102 = 301,

        /// <summary>
        /// For first channel of the DIY-devices led 103
        /// </summary>
        CLD_C1_103 = 302,

        /// <summary>
        /// For first channel of the DIY-devices led 104
        /// </summary>
        CLD_C1_104 = 303,

        /// <summary>
        /// For first channel of the DIY-devices led 105
        /// </summary>
        CLD_C1_105 = 304,

        /// <summary>
        /// For first channel of the DIY-devices led 106
        /// </summary>
        CLD_C1_106 = 305,

        /// <summary>
        /// For first channel of the DIY-devices led 107
        /// </summary>
        CLD_C1_107 = 306,

        /// <summary>
        /// For first channel of the DIY-devices led 108
        /// </summary>
        CLD_C1_108 = 307,

        /// <summary>
        /// For first channel of the DIY-devices led 109
        /// </summary>
        CLD_C1_109 = 308,

        /// <summary>
        /// For first channel of the DIY-devices led 110
        /// </summary>
        CLD_C1_110 = 309,

        /// <summary>
        /// For first channel of the DIY-devices led 111
        /// </summary>
        CLD_C1_111 = 310,

        /// <summary>
        /// For first channel of the DIY-devices led 112
        /// </summary>
        CLD_C1_112 = 311,

        /// <summary>
        /// For first channel of the DIY-devices led 113
        /// </summary>
        CLD_C1_113 = 312,

        /// <summary>
        /// For first channel of the DIY-devices led 114
        /// </summary>
        CLD_C1_114 = 313,

        /// <summary>
        /// For first channel of the DIY-devices led 115
        /// </summary>
        CLD_C1_115 = 314,

        /// <summary>
        /// For first channel of the DIY-devices led 116
        /// </summary>
        CLD_C1_116 = 315,

        /// <summary>
        /// For first channel of the DIY-devices led 117
        /// </summary>
        CLD_C1_117 = 316,

        /// <summary>
        /// For first channel of the DIY-devices led 118
        /// </summary>
        CLD_C1_118 = 317,

        /// <summary>
        /// For first channel of the DIY-devices led 119
        /// </summary>
        CLD_C1_119 = 318,

        /// <summary>
        /// For first channel of the DIY-devices led 120
        /// </summary>
        CLD_C1_120 = 319,

        /// <summary>
        /// For first channel of the DIY-devices led 121
        /// </summary>
        CLD_C1_121 = 320,

        /// <summary>
        /// For first channel of the DIY-devices led 122
        /// </summary>
        CLD_C1_122 = 321,

        /// <summary>
        /// For first channel of the DIY-devices led 123
        /// </summary>
        CLD_C1_123 = 322,

        /// <summary>
        /// For first channel of the DIY-devices led 124
        /// </summary>
        CLD_C1_124 = 323,

        /// <summary>
        /// For first channel of the DIY-devices led 125
        /// </summary>
        CLD_C1_125 = 324,

        /// <summary>
        /// For first channel of the DIY-devices led 126
        /// </summary>
        CLD_C1_126 = 325,

        /// <summary>
        /// For first channel of the DIY-devices led 127
        /// </summary>
        CLD_C1_127 = 326,

        /// <summary>
        /// For first channel of the DIY-devices led 128
        /// </summary>
        CLD_C1_128 = 327,

        /// <summary>
        /// For first channel of the DIY-devices led 129
        /// </summary>
        CLD_C1_129 = 328,

        /// <summary>
        /// For first channel of the DIY-devices led 130
        /// </summary>
        CLD_C1_130 = 329,

        /// <summary>
        /// For first channel of the DIY-devices led 131
        /// </summary>
        CLD_C1_131 = 330,

        /// <summary>
        /// For first channel of the DIY-devices led 132
        /// </summary>
        CLD_C1_132 = 331,

        /// <summary>
        /// For first channel of the DIY-devices led 133
        /// </summary>
        CLD_C1_133 = 332,

        /// <summary>
        /// For first channel of the DIY-devices led 134
        /// </summary>
        CLD_C1_134 = 333,

        /// <summary>
        /// For first channel of the DIY-devices led 135
        /// </summary>
        CLD_C1_135 = 334,

        /// <summary>
        /// For first channel of the DIY-devices led 136
        /// </summary>
        CLD_C1_136 = 335,

        /// <summary>
        /// For first channel of the DIY-devices led 137
        /// </summary>
        CLD_C1_137 = 336,

        /// <summary>
        /// For first channel of the DIY-devices led 138
        /// </summary>
        CLD_C1_138 = 337,

        /// <summary>
        /// For first channel of the DIY-devices led 139
        /// </summary>
        CLD_C1_139 = 338,

        /// <summary>
        /// For first channel of the DIY-devices led 140
        /// </summary>
        CLD_C1_140 = 339,

        /// <summary>
        /// For first channel of the DIY-devices led 141
        /// </summary>
        CLD_C1_141 = 340,

        /// <summary>
        /// For first channel of the DIY-devices led 142
        /// </summary>
        CLD_C1_142 = 341,

        /// <summary>
        /// For first channel of the DIY-devices led 143
        /// </summary>
        CLD_C1_143 = 342,

        /// <summary>
        /// For first channel of the DIY-devices led 144
        /// </summary>
        CLD_C1_144 = 343,

        /// <summary>
        /// For first channel of the DIY-devices led 145
        /// </summary>
        CLD_C1_145 = 344,

        /// <summary>
        /// For first channel of the DIY-devices led 146
        /// </summary>
        CLD_C1_146 = 345,

        /// <summary>
        /// For first channel of the DIY-devices led 147
        /// </summary>
        CLD_C1_147 = 346,

        /// <summary>
        /// For first channel of the DIY-devices led 148
        /// </summary>
        CLD_C1_148 = 347,

        /// <summary>
        /// For first channel of the DIY-devices led 149
        /// </summary>
        CLD_C1_149 = 348,

        /// <summary>
        /// For first channel of the DIY-devices led 150
        /// </summary>
        CLD_C1_150 = 349,

        /// <summary>
        /// For second channel of the DIY-devices led 1
        /// </summary>
        CLD_C2_1 = 350,

        /// <summary>
        /// For second channel of the DIY-devices led 2
        /// </summary>
        CLD_C2_2 = 351,

        /// <summary>
        /// For second channel of the DIY-devices led 3
        /// </summary>
        CLD_C2_3 = 352,

        /// <summary>
        /// For second channel of the DIY-devices led 4
        /// </summary>
        CLD_C2_4 = 353,

        /// <summary>
        /// For second channel of the DIY-devices led 5
        /// </summary>
        CLD_C2_5 = 354,

        /// <summary>
        /// For second channel of the DIY-devices led 6
        /// </summary>
        CLD_C2_6 = 355,

        /// <summary>
        /// For second channel of the DIY-devices led 7
        /// </summary>
        CLD_C2_7 = 356,

        /// <summary>
        /// For second channel of the DIY-devices led 8
        /// </summary>
        CLD_C2_8 = 357,

        /// <summary>
        /// For second channel of the DIY-devices led 9
        /// </summary>
        CLD_C2_9 = 358,

        /// <summary>
        /// For second channel of the DIY-devices led 10
        /// </summary>
        CLD_C2_10 = 359,

        /// <summary>
        /// For second channel of the DIY-devices led 11
        /// </summary>
        CLD_C2_11 = 360,

        /// <summary>
        /// For second channel of the DIY-devices led 12
        /// </summary>
        CLD_C2_12 = 361,

        /// <summary>
        /// For second channel of the DIY-devices led 13
        /// </summary>
        CLD_C2_13 = 362,

        /// <summary>
        /// For second channel of the DIY-devices led 14
        /// </summary>
        CLD_C2_14 = 363,

        /// <summary>
        /// For second channel of the DIY-devices led 15
        /// </summary>
        CLD_C2_15 = 364,

        /// <summary>
        /// For second channel of the DIY-devices led 16
        /// </summary>
        CLD_C2_16 = 365,

        /// <summary>
        /// For second channel of the DIY-devices led 17
        /// </summary>
        CLD_C2_17 = 366,

        /// <summary>
        /// For second channel of the DIY-devices led 18
        /// </summary>
        CLD_C2_18 = 367,

        /// <summary>
        /// For second channel of the DIY-devices led 19
        /// </summary>
        CLD_C2_19 = 368,

        /// <summary>
        /// For second channel of the DIY-devices led 20
        /// </summary>
        CLD_C2_20 = 369,

        /// <summary>
        /// For second channel of the DIY-devices led 21
        /// </summary>
        CLD_C2_21 = 370,

        /// <summary>
        /// For second channel of the DIY-devices led 22
        /// </summary>
        CLD_C2_22 = 371,

        /// <summary>
        /// For second channel of the DIY-devices led 23
        /// </summary>
        CLD_C2_23 = 372,

        /// <summary>
        /// For second channel of the DIY-devices led 24
        /// </summary>
        CLD_C2_24 = 373,

        /// <summary>
        /// For second channel of the DIY-devices led 25
        /// </summary>
        CLD_C2_25 = 374,

        /// <summary>
        /// For second channel of the DIY-devices led 26
        /// </summary>
        CLD_C2_26 = 375,

        /// <summary>
        /// For second channel of the DIY-devices led 27
        /// </summary>
        CLD_C2_27 = 376,

        /// <summary>
        /// For second channel of the DIY-devices led 28
        /// </summary>
        CLD_C2_28 = 377,

        /// <summary>
        /// For second channel of the DIY-devices led 29
        /// </summary>
        CLD_C2_29 = 378,

        /// <summary>
        /// For second channel of the DIY-devices led 30
        /// </summary>
        CLD_C2_30 = 379,

        /// <summary>
        /// For second channel of the DIY-devices led 31
        /// </summary>
        CLD_C2_31 = 380,

        /// <summary>
        /// For second channel of the DIY-devices led 32
        /// </summary>
        CLD_C2_32 = 381,

        /// <summary>
        /// For second channel of the DIY-devices led 33
        /// </summary>
        CLD_C2_33 = 382,

        /// <summary>
        /// For second channel of the DIY-devices led 34
        /// </summary>
        CLD_C2_34 = 383,

        /// <summary>
        /// For second channel of the DIY-devices led 35
        /// </summary>
        CLD_C2_35 = 384,

        /// <summary>
        /// For second channel of the DIY-devices led 36
        /// </summary>
        CLD_C2_36 = 385,

        /// <summary>
        /// For second channel of the DIY-devices led 37
        /// </summary>
        CLD_C2_37 = 386,

        /// <summary>
        /// For second channel of the DIY-devices led 38
        /// </summary>
        CLD_C2_38 = 387,

        /// <summary>
        /// For second channel of the DIY-devices led 39
        /// </summary>
        CLD_C2_39 = 388,

        /// <summary>
        /// For second channel of the DIY-devices led 40
        /// </summary>
        CLD_C2_40 = 389,

        /// <summary>
        /// For second channel of the DIY-devices led 41
        /// </summary>
        CLD_C2_41 = 390,

        /// <summary>
        /// For second channel of the DIY-devices led 42
        /// </summary>
        CLD_C2_42 = 391,

        /// <summary>
        /// For second channel of the DIY-devices led 43
        /// </summary>
        CLD_C2_43 = 392,

        /// <summary>
        /// For second channel of the DIY-devices led 44
        /// </summary>
        CLD_C2_44 = 393,

        /// <summary>
        /// For second channel of the DIY-devices led 45
        /// </summary>
        CLD_C2_45 = 394,

        /// <summary>
        /// For second channel of the DIY-devices led 46
        /// </summary>
        CLD_C2_46 = 395,

        /// <summary>
        /// For second channel of the DIY-devices led 47
        /// </summary>
        CLD_C2_47 = 396,

        /// <summary>
        /// For second channel of the DIY-devices led 48
        /// </summary>
        CLD_C2_48 = 397,

        /// <summary>
        /// For second channel of the DIY-devices led 49
        /// </summary>
        CLD_C2_49 = 398,

        /// <summary>
        /// For second channel of the DIY-devices led 50
        /// </summary>
        CLD_C2_50 = 399,

        /// <summary>
        /// For second channel of the DIY-devices led 51
        /// </summary>
        CLD_C2_51 = 400,

        /// <summary>
        /// For second channel of the DIY-devices led 52
        /// </summary>
        CLD_C2_52 = 401,

        /// <summary>
        /// For second channel of the DIY-devices led 53
        /// </summary>
        CLD_C2_53 = 402,

        /// <summary>
        /// For second channel of the DIY-devices led 54
        /// </summary>
        CLD_C2_54 = 403,

        /// <summary>
        /// For second channel of the DIY-devices led 55
        /// </summary>
        CLD_C2_55 = 404,

        /// <summary>
        /// For second channel of the DIY-devices led 56
        /// </summary>
        CLD_C2_56 = 405,

        /// <summary>
        /// For second channel of the DIY-devices led 57
        /// </summary>
        CLD_C2_57 = 406,

        /// <summary>
        /// For second channel of the DIY-devices led 58
        /// </summary>
        CLD_C2_58 = 407,

        /// <summary>
        /// For second channel of the DIY-devices led 59
        /// </summary>
        CLD_C2_59 = 408,

        /// <summary>
        /// For second channel of the DIY-devices led 60
        /// </summary>
        CLD_C2_60 = 409,

        /// <summary>
        /// For second channel of the DIY-devices led 61
        /// </summary>
        CLD_C2_61 = 410,

        /// <summary>
        /// For second channel of the DIY-devices led 62
        /// </summary>
        CLD_C2_62 = 411,

        /// <summary>
        /// For second channel of the DIY-devices led 63
        /// </summary>
        CLD_C2_63 = 412,

        /// <summary>
        /// For second channel of the DIY-devices led 64
        /// </summary>
        CLD_C2_64 = 413,

        /// <summary>
        /// For second channel of the DIY-devices led 65
        /// </summary>
        CLD_C2_65 = 414,

        /// <summary>
        /// For second channel of the DIY-devices led 66
        /// </summary>
        CLD_C2_66 = 415,

        /// <summary>
        /// For second channel of the DIY-devices led 67
        /// </summary>
        CLD_C2_67 = 416,

        /// <summary>
        /// For second channel of the DIY-devices led 68
        /// </summary>
        CLD_C2_68 = 417,

        /// <summary>
        /// For second channel of the DIY-devices led 69
        /// </summary>
        CLD_C2_69 = 418,

        /// <summary>
        /// For second channel of the DIY-devices led 70
        /// </summary>
        CLD_C2_70 = 419,

        /// <summary>
        /// For second channel of the DIY-devices led 71
        /// </summary>
        CLD_C2_71 = 420,

        /// <summary>
        /// For second channel of the DIY-devices led 72
        /// </summary>
        CLD_C2_72 = 421,

        /// <summary>
        /// For second channel of the DIY-devices led 73
        /// </summary>
        CLD_C2_73 = 422,

        /// <summary>
        /// For second channel of the DIY-devices led 74
        /// </summary>
        CLD_C2_74 = 423,

        /// <summary>
        /// For second channel of the DIY-devices led 75
        /// </summary>
        CLD_C2_75 = 424,

        /// <summary>
        /// For second channel of the DIY-devices led 76
        /// </summary>
        CLD_C2_76 = 425,

        /// <summary>
        /// For second channel of the DIY-devices led 77
        /// </summary>
        CLD_C2_77 = 426,

        /// <summary>
        /// For second channel of the DIY-devices led 78
        /// </summary>
        CLD_C2_78 = 427,

        /// <summary>
        /// For second channel of the DIY-devices led 79
        /// </summary>
        CLD_C2_79 = 428,

        /// <summary>
        /// For second channel of the DIY-devices led 80
        /// </summary>
        CLD_C2_80 = 429,

        /// <summary>
        /// For second channel of the DIY-devices led 81
        /// </summary>
        CLD_C2_81 = 430,

        /// <summary>
        /// For second channel of the DIY-devices led 82
        /// </summary>
        CLD_C2_82 = 431,

        /// <summary>
        /// For second channel of the DIY-devices led 83
        /// </summary>
        CLD_C2_83 = 432,

        /// <summary>
        /// For second channel of the DIY-devices led 84
        /// </summary>
        CLD_C2_84 = 433,

        /// <summary>
        /// For second channel of the DIY-devices led 85
        /// </summary>
        CLD_C2_85 = 434,

        /// <summary>
        /// For second channel of the DIY-devices led 86
        /// </summary>
        CLD_C2_86 = 435,

        /// <summary>
        /// For second channel of the DIY-devices led 87
        /// </summary>
        CLD_C2_87 = 436,

        /// <summary>
        /// For second channel of the DIY-devices led 88
        /// </summary>
        CLD_C2_88 = 437,

        /// <summary>
        /// For second channel of the DIY-devices led 89
        /// </summary>
        CLD_C2_89 = 438,

        /// <summary>
        /// For second channel of the DIY-devices led 90
        /// </summary>
        CLD_C2_90 = 439,

        /// <summary>
        /// For second channel of the DIY-devices led 91
        /// </summary>
        CLD_C2_91 = 440,

        /// <summary>
        /// For second channel of the DIY-devices led 92
        /// </summary>
        CLD_C2_92 = 441,

        /// <summary>
        /// For second channel of the DIY-devices led 93
        /// </summary>
        CLD_C2_93 = 442,

        /// <summary>
        /// For second channel of the DIY-devices led 94
        /// </summary>
        CLD_C2_94 = 443,

        /// <summary>
        /// For second channel of the DIY-devices led 95
        /// </summary>
        CLD_C2_95 = 444,

        /// <summary>
        /// For second channel of the DIY-devices led 96
        /// </summary>
        CLD_C2_96 = 445,

        /// <summary>
        /// For second channel of the DIY-devices led 97
        /// </summary>
        CLD_C2_97 = 446,

        /// <summary>
        /// For second channel of the DIY-devices led 98
        /// </summary>
        CLD_C2_98 = 447,

        /// <summary>
        /// For second channel of the DIY-devices led 99
        /// </summary>
        CLD_C2_99 = 448,

        /// <summary>
        /// For second channel of the DIY-devices led 100
        /// </summary>
        CLD_C2_100 = 449,

        /// <summary>
        /// For second channel of the DIY-devices led 101
        /// </summary>
        CLD_C2_101 = 450,

        /// <summary>
        /// For second channel of the DIY-devices led 102
        /// </summary>
        CLD_C2_102 = 451,

        /// <summary>
        /// For second channel of the DIY-devices led 103
        /// </summary>
        CLD_C2_103 = 452,

        /// <summary>
        /// For second channel of the DIY-devices led 104
        /// </summary>
        CLD_C2_104 = 453,

        /// <summary>
        /// For second channel of the DIY-devices led 105
        /// </summary>
        CLD_C2_105 = 454,

        /// <summary>
        /// For second channel of the DIY-devices led 106
        /// </summary>
        CLD_C2_106 = 455,

        /// <summary>
        /// For second channel of the DIY-devices led 107
        /// </summary>
        CLD_C2_107 = 456,

        /// <summary>
        /// For second channel of the DIY-devices led 108
        /// </summary>
        CLD_C2_108 = 457,

        /// <summary>
        /// For second channel of the DIY-devices led 109
        /// </summary>
        CLD_C2_109 = 458,

        /// <summary>
        /// For second channel of the DIY-devices led 110
        /// </summary>
        CLD_C2_110 = 459,

        /// <summary>
        /// For second channel of the DIY-devices led 111
        /// </summary>
        CLD_C2_111 = 460,

        /// <summary>
        /// For second channel of the DIY-devices led 112
        /// </summary>
        CLD_C2_112 = 461,

        /// <summary>
        /// For second channel of the DIY-devices led 113
        /// </summary>
        CLD_C2_113 = 462,

        /// <summary>
        /// For second channel of the DIY-devices led 114
        /// </summary>
        CLD_C2_114 = 463,

        /// <summary>
        /// For second channel of the DIY-devices led 115
        /// </summary>
        CLD_C2_115 = 464,

        /// <summary>
        /// For second channel of the DIY-devices led 116
        /// </summary>
        CLD_C2_116 = 465,

        /// <summary>
        /// For second channel of the DIY-devices led 117
        /// </summary>
        CLD_C2_117 = 466,

        /// <summary>
        /// For second channel of the DIY-devices led 118
        /// </summary>
        CLD_C2_118 = 467,

        /// <summary>
        /// For second channel of the DIY-devices led 119
        /// </summary>
        CLD_C2_119 = 468,

        /// <summary>
        /// For second channel of the DIY-devices led 120
        /// </summary>
        CLD_C2_120 = 469,

        /// <summary>
        /// For second channel of the DIY-devices led 121
        /// </summary>
        CLD_C2_121 = 470,

        /// <summary>
        /// For second channel of the DIY-devices led 122
        /// </summary>
        CLD_C2_122 = 471,

        /// <summary>
        /// For second channel of the DIY-devices led 123
        /// </summary>
        CLD_C2_123 = 472,

        /// <summary>
        /// For second channel of the DIY-devices led 124
        /// </summary>
        CLD_C2_124 = 473,

        /// <summary>
        /// For second channel of the DIY-devices led 125
        /// </summary>
        CLD_C2_125 = 474,

        /// <summary>
        /// For second channel of the DIY-devices led 126
        /// </summary>
        CLD_C2_126 = 475,

        /// <summary>
        /// For second channel of the DIY-devices led 127
        /// </summary>
        CLD_C2_127 = 476,

        /// <summary>
        /// For second channel of the DIY-devices led 128
        /// </summary>
        CLD_C2_128 = 477,

        /// <summary>
        /// For second channel of the DIY-devices led 129
        /// </summary>
        CLD_C2_129 = 478,

        /// <summary>
        /// For second channel of the DIY-devices led 130
        /// </summary>
        CLD_C2_130 = 479,

        /// <summary>
        /// For second channel of the DIY-devices led 131
        /// </summary>
        CLD_C2_131 = 480,

        /// <summary>
        /// For second channel of the DIY-devices led 132
        /// </summary>
        CLD_C2_132 = 481,

        /// <summary>
        /// For second channel of the DIY-devices led 133
        /// </summary>
        CLD_C2_133 = 482,

        /// <summary>
        /// For second channel of the DIY-devices led 134
        /// </summary>
        CLD_C2_134 = 483,

        /// <summary>
        /// For second channel of the DIY-devices led 135
        /// </summary>
        CLD_C2_135 = 484,

        /// <summary>
        /// For second channel of the DIY-devices led 136
        /// </summary>
        CLD_C2_136 = 485,

        /// <summary>
        /// For second channel of the DIY-devices led 137
        /// </summary>
        CLD_C2_137 = 486,

        /// <summary>
        /// For second channel of the DIY-devices led 138
        /// </summary>
        CLD_C2_138 = 487,

        /// <summary>
        /// For second channel of the DIY-devices led 139
        /// </summary>
        CLD_C2_139 = 488,

        /// <summary>
        /// For second channel of the DIY-devices led 140
        /// </summary>
        CLD_C2_140 = 489,

        /// <summary>
        /// For second channel of the DIY-devices led 141
        /// </summary>
        CLD_C2_141 = 490,

        /// <summary>
        /// For second channel of the DIY-devices led 142
        /// </summary>
        CLD_C2_142 = 491,

        /// <summary>
        /// For second channel of the DIY-devices led 143
        /// </summary>
        CLD_C2_143 = 492,

        /// <summary>
        /// For second channel of the DIY-devices led 144
        /// </summary>
        CLD_C2_144 = 493,

        /// <summary>
        /// For second channel of the DIY-devices led 145
        /// </summary>
        CLD_C2_145 = 494,

        /// <summary>
        /// For second channel of the DIY-devices led 146
        /// </summary>
        CLD_C2_146 = 495,

        /// <summary>
        /// For second channel of the DIY-devices led 147
        /// </summary>
        CLD_C2_147 = 496,

        /// <summary>
        /// For second channel of the DIY-devices led 148
        /// </summary>
        CLD_C2_148 = 497,

        /// <summary>
        /// For second channel of the DIY-devices led 149
        /// </summary>
        CLD_C2_149 = 498,

        /// <summary>
        /// For second channel of the DIY-devices led 150
        /// </summary>
        CLD_C2_150 = 499,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem1 = 500,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem2 = 501,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem3 = 502,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem4 = 503,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem5 = 504,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem6 = 505,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem7 = 506,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem8 = 507,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem9 = 508,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem10 = 509,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem11 = 510,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem12 = 511,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem13 = 512,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem14 = 513,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem15 = 514,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem16 = 515,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem17 = 516,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem18 = 517,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem19 = 518,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem20 = 519,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem21 = 520,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem22 = 521,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem23 = 522,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem24 = 523,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem25 = 524,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem26 = 525,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem27 = 526,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem28 = 527,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem29 = 528,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem30 = 529,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem31 = 530,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem32 = 531,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem33 = 532,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem34 = 533,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem35 = 534,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem36 = 535,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem37 = 536,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem38 = 537,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem39 = 538,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem40 = 539,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem41 = 540,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem42 = 541,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem43 = 542,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem44 = 543,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem45 = 544,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem46 = 545,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem47 = 546,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem48 = 547,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem49 = 548,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem50 = 549,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem51 = 550,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem52 = 551,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem53 = 552,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem54 = 553,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem55 = 554,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem56 = 555,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem57 = 556,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem58 = 557,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem59 = 558,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem60 = 559,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem61 = 560,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem62 = 561,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem63 = 562,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem64 = 563,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem65 = 564,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem66 = 565,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem67 = 566,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem68 = 567,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem69 = 568,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem70 = 569,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem71 = 570,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem72 = 571,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem73 = 572,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem74 = 573,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem75 = 574,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem76 = 575,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem77 = 576,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem78 = 577,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem79 = 578,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem80 = 579,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem81 = 580,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem82 = 581,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem83 = 582,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem84 = 583,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem85 = 584,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem86 = 585,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem87 = 586,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem88 = 587,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem89 = 588,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem90 = 589,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem91 = 590,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem92 = 591,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem93 = 592,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem94 = 593,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem95 = 594,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem96 = 595,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem97 = 596,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem98 = 597,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem99 = 598,

        /// <summary>
        /// Reserved for custom led
        /// </summary>
        CLI_Oem100 = 599,

        /// <summary>
        /// For memory module led 1
        /// </summary>
        CLDRAM_1 = 600,

        /// <summary>
        /// For memory module led 2
        /// </summary>
        CLDRAM_2 = 601,

        /// <summary>
        /// For memory module led 3
        /// </summary>
        CLDRAM_3 = 602,

        /// <summary>
        /// For memory module led 4
        /// </summary>
        CLDRAM_4 = 603,

        /// <summary>
        /// For memory module led 5
        /// </summary>
        CLDRAM_5 = 604,

        /// <summary>
        /// For memory module led 6
        /// </summary>
        CLDRAM_6 = 605,

        /// <summary>
        /// For memory module led 7
        /// </summary>
        CLDRAM_7 = 606,

        /// <summary>
        /// For memory module led 8
        /// </summary>
        CLDRAM_8 = 607,

        /// <summary>
        /// For memory module led 9
        /// </summary>
        CLDRAM_9 = 608,

        /// <summary>
        /// For memory module led 10
        /// </summary>
        CLDRAM_10 = 609,

        /// <summary>
        /// For memory module led 11
        /// </summary>
        CLDRAM_11 = 610,

        /// <summary>
        /// For memory module led 12
        /// </summary>
        CLDRAM_12 = 611,

        /// <summary>
        /// For third channel of the DIY-devices led 1
        /// </summary>
        CLD_C3_1 = 612,

        /// <summary>
        /// For third channel of the DIY-devices led 2
        /// </summary>
        CLD_C3_2 = 613,

        /// <summary>
        /// For third channel of the DIY-devices led 3
        /// </summary>
        CLD_C3_3 = 614,

        /// <summary>
        /// For third channel of the DIY-devices led 4
        /// </summary>
        CLD_C3_4 = 615,

        /// <summary>
        /// For third channel of the DIY-devices led 5
        /// </summary>
        CLD_C3_5 = 616,

        /// <summary>
        /// For third channel of the DIY-devices led 6
        /// </summary>
        CLD_C3_6 = 617,

        /// <summary>
        /// For third channel of the DIY-devices led 7
        /// </summary>
        CLD_C3_7 = 618,

        /// <summary>
        /// For third channel of the DIY-devices led 8
        /// </summary>
        CLD_C3_8 = 619,

        /// <summary>
        /// For third channel of the DIY-devices led 9
        /// </summary>
        CLD_C3_9 = 620,

        /// <summary>
        /// For third channel of the DIY-devices led 10
        /// </summary>
        CLD_C3_10 = 621,

        /// <summary>
        /// For third channel of the DIY-devices led 11
        /// </summary>
        CLD_C3_11 = 622,

        /// <summary>
        /// For third channel of the DIY-devices led 12
        /// </summary>
        CLD_C3_12 = 623,

        /// <summary>
        /// For third channel of the DIY-devices led 13
        /// </summary>
        CLD_C3_13 = 624,

        /// <summary>
        /// For third channel of the DIY-devices led 14
        /// </summary>
        CLD_C3_14 = 625,

        /// <summary>
        /// For third channel of the DIY-devices led 15
        /// </summary>
        CLD_C3_15 = 626,

        /// <summary>
        /// For third channel of the DIY-devices led 16
        /// </summary>
        CLD_C3_16 = 627,

        /// <summary>
        /// For third channel of the DIY-devices led 17
        /// </summary>
        CLD_C3_17 = 628,

        /// <summary>
        /// For third channel of the DIY-devices led 18
        /// </summary>
        CLD_C3_18 = 629,

        /// <summary>
        /// For third channel of the DIY-devices led 19
        /// </summary>
        CLD_C3_19 = 630,

        /// <summary>
        /// For third channel of the DIY-devices led 20
        /// </summary>
        CLD_C3_20 = 631,

        /// <summary>
        /// For third channel of the DIY-devices led 21
        /// </summary>
        CLD_C3_21 = 632,

        /// <summary>
        /// For third channel of the DIY-devices led 22
        /// </summary>
        CLD_C3_22 = 633,

        /// <summary>
        /// For third channel of the DIY-devices led 23
        /// </summary>
        CLD_C3_23 = 634,

        /// <summary>
        /// For third channel of the DIY-devices led 24
        /// </summary>
        CLD_C3_24 = 635,

        /// <summary>
        /// For third channel of the DIY-devices led 25
        /// </summary>
        CLD_C3_25 = 636,

        /// <summary>
        /// For third channel of the DIY-devices led 26
        /// </summary>
        CLD_C3_26 = 637,

        /// <summary>
        /// For third channel of the DIY-devices led 27
        /// </summary>
        CLD_C3_27 = 638,

        /// <summary>
        /// For third channel of the DIY-devices led 28
        /// </summary>
        CLD_C3_28 = 639,

        /// <summary>
        /// For third channel of the DIY-devices led 29
        /// </summary>
        CLD_C3_29 = 640,

        /// <summary>
        /// For third channel of the DIY-devices led 30
        /// </summary>
        CLD_C3_30 = 641,

        /// <summary>
        /// For third channel of the DIY-devices led 31
        /// </summary>
        CLD_C3_31 = 642,

        /// <summary>
        /// For third channel of the DIY-devices led 32
        /// </summary>
        CLD_C3_32 = 643,

        /// <summary>
        /// For third channel of the DIY-devices led 33
        /// </summary>
        CLD_C3_33 = 644,

        /// <summary>
        /// For third channel of the DIY-devices led 34
        /// </summary>
        CLD_C3_34 = 645,

        /// <summary>
        /// For third channel of the DIY-devices led 35
        /// </summary>
        CLD_C3_35 = 646,

        /// <summary>
        /// For third channel of the DIY-devices led 36
        /// </summary>
        CLD_C3_36 = 647,

        /// <summary>
        /// For third channel of the DIY-devices led 37
        /// </summary>
        CLD_C3_37 = 648,

        /// <summary>
        /// For third channel of the DIY-devices led 38
        /// </summary>
        CLD_C3_38 = 649,

        /// <summary>
        /// For third channel of the DIY-devices led 39
        /// </summary>
        CLD_C3_39 = 650,

        /// <summary>
        /// For third channel of the DIY-devices led 40
        /// </summary>
        CLD_C3_40 = 651,

        /// <summary>
        /// For third channel of the DIY-devices led 41
        /// </summary>
        CLD_C3_41 = 652,

        /// <summary>
        /// For third channel of the DIY-devices led 42
        /// </summary>
        CLD_C3_42 = 653,

        /// <summary>
        /// For third channel of the DIY-devices led 43
        /// </summary>
        CLD_C3_43 = 654,

        /// <summary>
        /// For third channel of the DIY-devices led 44
        /// </summary>
        CLD_C3_44 = 655,

        /// <summary>
        /// For third channel of the DIY-devices led 45
        /// </summary>
        CLD_C3_45 = 656,

        /// <summary>
        /// For third channel of the DIY-devices led 46
        /// </summary>
        CLD_C3_46 = 657,

        /// <summary>
        /// For third channel of the DIY-devices led 47
        /// </summary>
        CLD_C3_47 = 658,

        /// <summary>
        /// For third channel of the DIY-devices led 48
        /// </summary>
        CLD_C3_48 = 659,

        /// <summary>
        /// For third channel of the DIY-devices led 49
        /// </summary>
        CLD_C3_49 = 660,

        /// <summary>
        /// For third channel of the DIY-devices led 50
        /// </summary>
        CLD_C3_50 = 661,

        /// <summary>
        /// For third channel of the DIY-devices led 51
        /// </summary>
        CLD_C3_51 = 662,

        /// <summary>
        /// For third channel of the DIY-devices led 52
        /// </summary>
        CLD_C3_52 = 663,

        /// <summary>
        /// For third channel of the DIY-devices led 53
        /// </summary>
        CLD_C3_53 = 664,

        /// <summary>
        /// For third channel of the DIY-devices led 54
        /// </summary>
        CLD_C3_54 = 665,

        /// <summary>
        /// For third channel of the DIY-devices led 55
        /// </summary>
        CLD_C3_55 = 666,

        /// <summary>
        /// For third channel of the DIY-devices led 56
        /// </summary>
        CLD_C3_56 = 667,

        /// <summary>
        /// For third channel of the DIY-devices led 57
        /// </summary>
        CLD_C3_57 = 668,

        /// <summary>
        /// For third channel of the DIY-devices led 58
        /// </summary>
        CLD_C3_58 = 669,

        /// <summary>
        /// For third channel of the DIY-devices led 59
        /// </summary>
        CLD_C3_59 = 670,

        /// <summary>
        /// For third channel of the DIY-devices led 60
        /// </summary>
        CLD_C3_60 = 671,

        /// <summary>
        /// For third channel of the DIY-devices led 61
        /// </summary>
        CLD_C3_61 = 672,

        /// <summary>
        /// For third channel of the DIY-devices led 62
        /// </summary>
        CLD_C3_62 = 673,

        /// <summary>
        /// For third channel of the DIY-devices led 63
        /// </summary>
        CLD_C3_63 = 674,

        /// <summary>
        /// For third channel of the DIY-devices led 64
        /// </summary>
        CLD_C3_64 = 675,

        /// <summary>
        /// For third channel of the DIY-devices led 65
        /// </summary>
        CLD_C3_65 = 676,

        /// <summary>
        /// For third channel of the DIY-devices led 66
        /// </summary>
        CLD_C3_66 = 677,

        /// <summary>
        /// For third channel of the DIY-devices led 67
        /// </summary>
        CLD_C3_67 = 678,

        /// <summary>
        /// For third channel of the DIY-devices led 68
        /// </summary>
        CLD_C3_68 = 679,

        /// <summary>
        /// For third channel of the DIY-devices led 69
        /// </summary>
        CLD_C3_69 = 680,

        /// <summary>
        /// For third channel of the DIY-devices led 70
        /// </summary>
        CLD_C3_70 = 681,

        /// <summary>
        /// For third channel of the DIY-devices led 71
        /// </summary>
        CLD_C3_71 = 682,

        /// <summary>
        /// For third channel of the DIY-devices led 72
        /// </summary>
        CLD_C3_72 = 683,

        /// <summary>
        /// For third channel of the DIY-devices led 73
        /// </summary>
        CLD_C3_73 = 684,

        /// <summary>
        /// For third channel of the DIY-devices led 74
        /// </summary>
        CLD_C3_74 = 685,

        /// <summary>
        /// For third channel of the DIY-devices led 75
        /// </summary>
        CLD_C3_75 = 686,

        /// <summary>
        /// For third channel of the DIY-devices led 76
        /// </summary>
        CLD_C3_76 = 687,

        /// <summary>
        /// For third channel of the DIY-devices led 77
        /// </summary>
        CLD_C3_77 = 688,

        /// <summary>
        /// For third channel of the DIY-devices led 78
        /// </summary>
        CLD_C3_78 = 689,

        /// <summary>
        /// For third channel of the DIY-devices led 79
        /// </summary>
        CLD_C3_79 = 690,

        /// <summary>
        /// For third channel of the DIY-devices led 80
        /// </summary>
        CLD_C3_80 = 691,

        /// <summary>
        /// For third channel of the DIY-devices led 81
        /// </summary>
        CLD_C3_81 = 692,

        /// <summary>
        /// For third channel of the DIY-devices led 82
        /// </summary>
        CLD_C3_82 = 693,

        /// <summary>
        /// For third channel of the DIY-devices led 83
        /// </summary>
        CLD_C3_83 = 694,

        /// <summary>
        /// For third channel of the DIY-devices led 84
        /// </summary>
        CLD_C3_84 = 695,

        /// <summary>
        /// For third channel of the DIY-devices led 85
        /// </summary>
        CLD_C3_85 = 696,

        /// <summary>
        /// For third channel of the DIY-devices led 86
        /// </summary>
        CLD_C3_86 = 697,

        /// <summary>
        /// For third channel of the DIY-devices led 87
        /// </summary>
        CLD_C3_87 = 698,

        /// <summary>
        /// For third channel of the DIY-devices led 88
        /// </summary>
        CLD_C3_88 = 699,

        /// <summary>
        /// For third channel of the DIY-devices led 89
        /// </summary>
        CLD_C3_89 = 700,

        /// <summary>
        /// For third channel of the DIY-devices led 90
        /// </summary>
        CLD_C3_90 = 701,

        /// <summary>
        /// For third channel of the DIY-devices led 91
        /// </summary>
        CLD_C3_91 = 702,

        /// <summary>
        /// For third channel of the DIY-devices led 92
        /// </summary>
        CLD_C3_92 = 703,

        /// <summary>
        /// For third channel of the DIY-devices led 93
        /// </summary>
        CLD_C3_93 = 704,

        /// <summary>
        /// For third channel of the DIY-devices led 94
        /// </summary>
        CLD_C3_94 = 705,

        /// <summary>
        /// For third channel of the DIY-devices led 95
        /// </summary>
        CLD_C3_95 = 706,

        /// <summary>
        /// For third channel of the DIY-devices led 96
        /// </summary>
        CLD_C3_96 = 707,

        /// <summary>
        /// For third channel of the DIY-devices led 97
        /// </summary>
        CLD_C3_97 = 708,

        /// <summary>
        /// For third channel of the DIY-devices led 98
        /// </summary>
        CLD_C3_98 = 709,

        /// <summary>
        /// For third channel of the DIY-devices led 99
        /// </summary>
        CLD_C3_99 = 710,

        /// <summary>
        /// For third channel of the DIY-devices led 100
        /// </summary>
        CLD_C3_100 = 711,

        /// <summary>
        /// For third channel of the DIY-devices led 101
        /// </summary>
        CLD_C3_101 = 712,

        /// <summary>
        /// For third channel of the DIY-devices led 102
        /// </summary>
        CLD_C3_102 = 713,

        /// <summary>
        /// For third channel of the DIY-devices led 103
        /// </summary>
        CLD_C3_103 = 714,

        /// <summary>
        /// For third channel of the DIY-devices led 104
        /// </summary>
        CLD_C3_104 = 715,

        /// <summary>
        /// For third channel of the DIY-devices led 105
        /// </summary>
        CLD_C3_105 = 716,

        /// <summary>
        /// For third channel of the DIY-devices led 106
        /// </summary>
        CLD_C3_106 = 717,

        /// <summary>
        /// For third channel of the DIY-devices led 107
        /// </summary>
        CLD_C3_107 = 718,

        /// <summary>
        /// For third channel of the DIY-devices led 108
        /// </summary>
        CLD_C3_108 = 719,

        /// <summary>
        /// For third channel of the DIY-devices led 109
        /// </summary>
        CLD_C3_109 = 720,

        /// <summary>
        /// For third channel of the DIY-devices led 110
        /// </summary>
        CLD_C3_110 = 721,

        /// <summary>
        /// For third channel of the DIY-devices led 111
        /// </summary>
        CLD_C3_111 = 722,

        /// <summary>
        /// For third channel of the DIY-devices led 112
        /// </summary>
        CLD_C3_112 = 723,

        /// <summary>
        /// For third channel of the DIY-devices led 113
        /// </summary>
        CLD_C3_113 = 724,

        /// <summary>
        /// For third channel of the DIY-devices led 114
        /// </summary>
        CLD_C3_114 = 725,

        /// <summary>
        /// For third channel of the DIY-devices led 115
        /// </summary>
        CLD_C3_115 = 726,

        /// <summary>
        /// For third channel of the DIY-devices led 116
        /// </summary>
        CLD_C3_116 = 727,

        /// <summary>
        /// For third channel of the DIY-devices led 117
        /// </summary>
        CLD_C3_117 = 728,

        /// <summary>
        /// For third channel of the DIY-devices led 118
        /// </summary>
        CLD_C3_118 = 729,

        /// <summary>
        /// For third channel of the DIY-devices led 119
        /// </summary>
        CLD_C3_119 = 730,

        /// <summary>
        /// For third channel of the DIY-devices led 120
        /// </summary>
        CLD_C3_120 = 731,

        /// <summary>
        /// For third channel of the DIY-devices led 121
        /// </summary>
        CLD_C3_121 = 732,

        /// <summary>
        /// For third channel of the DIY-devices led 122
        /// </summary>
        CLD_C3_122 = 733,

        /// <summary>
        /// For third channel of the DIY-devices led 123
        /// </summary>
        CLD_C3_123 = 734,

        /// <summary>
        /// For third channel of the DIY-devices led 124
        /// </summary>
        CLD_C3_124 = 735,

        /// <summary>
        /// For third channel of the DIY-devices led 125
        /// </summary>
        CLD_C3_125 = 736,

        /// <summary>
        /// For third channel of the DIY-devices led 126
        /// </summary>
        CLD_C3_126 = 737,

        /// <summary>
        /// For third channel of the DIY-devices led 127
        /// </summary>
        CLD_C3_127 = 738,

        /// <summary>
        /// For third channel of the DIY-devices led 128
        /// </summary>
        CLD_C3_128 = 739,

        /// <summary>
        /// For third channel of the DIY-devices led 129
        /// </summary>
        CLD_C3_129 = 740,

        /// <summary>
        /// For third channel of the DIY-devices led 130
        /// </summary>
        CLD_C3_130 = 741,

        /// <summary>
        /// For third channel of the DIY-devices led 131
        /// </summary>
        CLD_C3_131 = 742,

        /// <summary>
        /// For third channel of the DIY-devices led 132
        /// </summary>
        CLD_C3_132 = 743,

        /// <summary>
        /// For third channel of the DIY-devices led 133
        /// </summary>
        CLD_C3_133 = 744,

        /// <summary>
        /// For third channel of the DIY-devices led 134
        /// </summary>
        CLD_C3_134 = 745,

        /// <summary>
        /// For third channel of the DIY-devices led 135
        /// </summary>
        CLD_C3_135 = 746,

        /// <summary>
        /// For third channel of the DIY-devices led 136
        /// </summary>
        CLD_C3_136 = 747,

        /// <summary>
        /// For third channel of the DIY-devices led 137
        /// </summary>
        CLD_C3_137 = 748,

        /// <summary>
        /// For third channel of the DIY-devices led 138
        /// </summary>
        CLD_C3_138 = 749,

        /// <summary>
        /// For third channel of the DIY-devices led 139
        /// </summary>
        CLD_C3_139 = 750,

        /// <summary>
        /// For third channel of the DIY-devices led 140
        /// </summary>
        CLD_C3_140 = 751,

        /// <summary>
        /// For third channel of the DIY-devices led 141
        /// </summary>
        CLD_C3_141 = 752,

        /// <summary>
        /// For third channel of the DIY-devices led 142
        /// </summary>
        CLD_C3_142 = 753,

        /// <summary>
        /// For third channel of the DIY-devices led 143
        /// </summary>
        CLD_C3_143 = 754,

        /// <summary>
        /// For third channel of the DIY-devices led 144
        /// </summary>
        CLD_C3_144 = 755,

        /// <summary>
        /// For third channel of the DIY-devices led 145
        /// </summary>
        CLD_C3_145 = 756,

        /// <summary>
        /// For third channel of the DIY-devices led 146
        /// </summary>
        CLD_C3_146 = 757,

        /// <summary>
        /// For third channel of the DIY-devices led 147
        /// </summary>
        CLD_C3_147 = 758,

        /// <summary>
        /// For third channel of the DIY-devices led 148
        /// </summary>
        CLD_C3_148 = 759,

        /// <summary>
        /// For third channel of the DIY-devices led 149
        /// </summary>
        CLD_C3_149 = 760,

        /// <summary>
        /// For third channel of the DIY-devices led 150
        /// </summary>
        CLD_C3_150 = 761,

        /// <summary>
        /// For first channel of the liquid coolers led 1
        /// </summary>
        CLLC_C1_1 = 762,

        /// <summary>
        /// For first channel of the liquid coolers led 2
        /// </summary>
        CLLC_C1_2 = 763,

        /// <summary>
        /// For first channel of the liquid coolers led 3
        /// </summary>
        CLLC_C1_3 = 764,

        /// <summary>
        /// For first channel of the liquid coolers led 4
        /// </summary>
        CLLC_C1_4 = 765,

        /// <summary>
        /// For first channel of the liquid coolers led 5
        /// </summary>
        CLLC_C1_5 = 766,

        /// <summary>
        /// For first channel of the liquid coolers led 6
        /// </summary>
        CLLC_C1_6 = 767,

        /// <summary>
        /// For first channel of the liquid coolers led 7
        /// </summary>
        CLLC_C1_7 = 768,

        /// <summary>
        /// For first channel of the liquid coolers led 8
        /// </summary>
        CLLC_C1_8 = 769,

        /// <summary>
        /// For first channel of the liquid coolers led 9
        /// </summary>
        CLLC_C1_9 = 770,

        /// <summary>
        /// For first channel of the liquid coolers led 10
        /// </summary>
        CLLC_C1_10 = 771,

        /// <summary>
        /// For first channel of the liquid coolers led 11
        /// </summary>
        CLLC_C1_11 = 772,

        /// <summary>
        /// For first channel of the liquid coolers led 12
        /// </summary>
        CLLC_C1_12 = 773,

        /// <summary>
        /// For first channel of the liquid coolers led 13
        /// </summary>
        CLLC_C1_13 = 774,

        /// <summary>
        /// For first channel of the liquid coolers led 14
        /// </summary>
        CLLC_C1_14 = 775,

        /// <summary>
        /// For first channel of the liquid coolers led 15
        /// </summary>
        CLLC_C1_15 = 776,

        /// <summary>
        /// For first channel of the liquid coolers led 16
        /// </summary>
        CLLC_C1_16 = 777,

        /// <summary>
        /// For first channel of the liquid coolers led 17
        /// </summary>
        CLLC_C1_17 = 778,

        /// <summary>
        /// For first channel of the liquid coolers led 18
        /// </summary>
        CLLC_C1_18 = 779,

        /// <summary>
        /// For first channel of the liquid coolers led 19
        /// </summary>
        CLLC_C1_19 = 780,

        /// <summary>
        /// For first channel of the liquid coolers led 20
        /// </summary>
        CLLC_C1_20 = 781,

        /// <summary>
        /// For first channel of the liquid coolers led 21
        /// </summary>
        CLLC_C1_21 = 782,

        /// <summary>
        /// For first channel of the liquid coolers led 22
        /// </summary>
        CLLC_C1_22 = 783,

        /// <summary>
        /// For first channel of the liquid coolers led 23
        /// </summary>
        CLLC_C1_23 = 784,

        /// <summary>
        /// For first channel of the liquid coolers led 24
        /// </summary>
        CLLC_C1_24 = 785,

        /// <summary>
        /// For first channel of the liquid coolers led 25
        /// </summary>
        CLLC_C1_25 = 786,

        /// <summary>
        /// For first channel of the liquid coolers led 26
        /// </summary>
        CLLC_C1_26 = 787,

        /// <summary>
        /// For first channel of the liquid coolers led 27
        /// </summary>
        CLLC_C1_27 = 788,

        /// <summary>
        /// For first channel of the liquid coolers led 28
        /// </summary>
        CLLC_C1_28 = 789,

        /// <summary>
        /// For first channel of the liquid coolers led 29
        /// </summary>
        CLLC_C1_29 = 790,

        /// <summary>
        /// For first channel of the liquid coolers led 30
        /// </summary>
        CLLC_C1_30 = 791,

        /// <summary>
        /// For first channel of the liquid coolers led 31
        /// </summary>
        CLLC_C1_31 = 792,

        /// <summary>
        /// For first channel of the liquid coolers led 32
        /// </summary>
        CLLC_C1_32 = 793,

        /// <summary>
        /// For first channel of the liquid coolers led 33
        /// </summary>
        CLLC_C1_33 = 794,

        /// <summary>
        /// For first channel of the liquid coolers led 34
        /// </summary>
        CLLC_C1_34 = 795,

        /// <summary>
        /// For first channel of the liquid coolers led 35
        /// </summary>
        CLLC_C1_35 = 796,

        /// <summary>
        /// For first channel of the liquid coolers led 36
        /// </summary>
        CLLC_C1_36 = 797,

        /// <summary>
        /// For first channel of the liquid coolers led 37
        /// </summary>
        CLLC_C1_37 = 798,

        /// <summary>
        /// For first channel of the liquid coolers led 38
        /// </summary>
        CLLC_C1_38 = 799,

        /// <summary>
        /// For first channel of the liquid coolers led 39
        /// </summary>
        CLLC_C1_39 = 800,

        /// <summary>
        /// For first channel of the liquid coolers led 40
        /// </summary>
        CLLC_C1_40 = 801,

        /// <summary>
        /// For first channel of the liquid coolers led 41
        /// </summary>
        CLLC_C1_41 = 802,

        /// <summary>
        /// For first channel of the liquid coolers led 42
        /// </summary>
        CLLC_C1_42 = 803,

        /// <summary>
        /// For first channel of the liquid coolers led 43
        /// </summary>
        CLLC_C1_43 = 804,

        /// <summary>
        /// For first channel of the liquid coolers led 44
        /// </summary>
        CLLC_C1_44 = 805,

        /// <summary>
        /// For first channel of the liquid coolers led 45
        /// </summary>
        CLLC_C1_45 = 806,

        /// <summary>
        /// For first channel of the liquid coolers led 46
        /// </summary>
        CLLC_C1_46 = 807,

        /// <summary>
        /// For first channel of the liquid coolers led 47
        /// </summary>
        CLLC_C1_47 = 808,

        /// <summary>
        /// For first channel of the liquid coolers led 48
        /// </summary>
        CLLC_C1_48 = 809,

        /// <summary>
        /// For first channel of the liquid coolers led 49
        /// </summary>
        CLLC_C1_49 = 810,

        /// <summary>
        /// For first channel of the liquid coolers led 50
        /// </summary>
        CLLC_C1_50 = 811,

        /// <summary>
        /// For first channel of the liquid coolers led 51
        /// </summary>
        CLLC_C1_51 = 812,

        /// <summary>
        /// For first channel of the liquid coolers led 52
        /// </summary>
        CLLC_C1_52 = 813,

        /// <summary>
        /// For first channel of the liquid coolers led 53
        /// </summary>
        CLLC_C1_53 = 814,

        /// <summary>
        /// For first channel of the liquid coolers led 54
        /// </summary>
        CLLC_C1_54 = 815,

        /// <summary>
        /// For first channel of the liquid coolers led 55
        /// </summary>
        CLLC_C1_55 = 816,

        /// <summary>
        /// For first channel of the liquid coolers led 56
        /// </summary>
        CLLC_C1_56 = 817,

        /// <summary>
        /// For first channel of the liquid coolers led 57
        /// </summary>
        CLLC_C1_57 = 818,

        /// <summary>
        /// For first channel of the liquid coolers led 58
        /// </summary>
        CLLC_C1_58 = 819,

        /// <summary>
        /// For first channel of the liquid coolers led 59
        /// </summary>
        CLLC_C1_59 = 820,

        /// <summary>
        /// For first channel of the liquid coolers led 60
        /// </summary>
        CLLC_C1_60 = 821,

        /// <summary>
        /// For first channel of the liquid coolers led 61
        /// </summary>
        CLLC_C1_61 = 822,

        /// <summary>
        /// For first channel of the liquid coolers led 62
        /// </summary>
        CLLC_C1_62 = 823,

        /// <summary>
        /// For first channel of the liquid coolers led 63
        /// </summary>
        CLLC_C1_63 = 824,

        /// <summary>
        /// For first channel of the liquid coolers led 64
        /// </summary>
        CLLC_C1_64 = 825,

        /// <summary>
        /// For first channel of the liquid coolers led 65
        /// </summary>
        CLLC_C1_65 = 826,

        /// <summary>
        /// For first channel of the liquid coolers led 66
        /// </summary>
        CLLC_C1_66 = 827,

        /// <summary>
        /// For first channel of the liquid coolers led 67
        /// </summary>
        CLLC_C1_67 = 828,

        /// <summary>
        /// For first channel of the liquid coolers led 68
        /// </summary>
        CLLC_C1_68 = 829,

        /// <summary>
        /// For first channel of the liquid coolers led 69
        /// </summary>
        CLLC_C1_69 = 830,

        /// <summary>
        /// For first channel of the liquid coolers led 70
        /// </summary>
        CLLC_C1_70 = 831,

        /// <summary>
        /// For first channel of the liquid coolers led 71
        /// </summary>
        CLLC_C1_71 = 832,

        /// <summary>
        /// For first channel of the liquid coolers led 72
        /// </summary>
        CLLC_C1_72 = 833,

        /// <summary>
        /// For first channel of the liquid coolers led 73
        /// </summary>
        CLLC_C1_73 = 834,

        /// <summary>
        /// For first channel of the liquid coolers led 74
        /// </summary>
        CLLC_C1_74 = 835,

        /// <summary>
        /// For first channel of the liquid coolers led 75
        /// </summary>
        CLLC_C1_75 = 836,

        /// <summary>
        /// For first channel of the liquid coolers led 76
        /// </summary>
        CLLC_C1_76 = 837,

        /// <summary>
        /// For first channel of the liquid coolers led 77
        /// </summary>
        CLLC_C1_77 = 838,

        /// <summary>
        /// For first channel of the liquid coolers led 78
        /// </summary>
        CLLC_C1_78 = 839,

        /// <summary>
        /// For first channel of the liquid coolers led 79
        /// </summary>
        CLLC_C1_79 = 840,

        /// <summary>
        /// For first channel of the liquid coolers led 80
        /// </summary>
        CLLC_C1_80 = 841,

        /// <summary>
        /// For first channel of the liquid coolers led 81
        /// </summary>
        CLLC_C1_81 = 842,

        /// <summary>
        /// For first channel of the liquid coolers led 82
        /// </summary>
        CLLC_C1_82 = 843,

        /// <summary>
        /// For first channel of the liquid coolers led 83
        /// </summary>
        CLLC_C1_83 = 844,

        /// <summary>
        /// For first channel of the liquid coolers led 84
        /// </summary>
        CLLC_C1_84 = 845,

        /// <summary>
        /// For first channel of the liquid coolers led 85
        /// </summary>
        CLLC_C1_85 = 846,

        /// <summary>
        /// For first channel of the liquid coolers led 86
        /// </summary>
        CLLC_C1_86 = 847,

        /// <summary>
        /// For first channel of the liquid coolers led 87
        /// </summary>
        CLLC_C1_87 = 848,

        /// <summary>
        /// For first channel of the liquid coolers led 88
        /// </summary>
        CLLC_C1_88 = 849,

        /// <summary>
        /// For first channel of the liquid coolers led 89
        /// </summary>
        CLLC_C1_89 = 850,

        /// <summary>
        /// For first channel of the liquid coolers led 90
        /// </summary>
        CLLC_C1_90 = 851,

        /// <summary>
        /// For first channel of the liquid coolers led 91
        /// </summary>
        CLLC_C1_91 = 852,

        /// <summary>
        /// For first channel of the liquid coolers led 92
        /// </summary>
        CLLC_C1_92 = 853,

        /// <summary>
        /// For first channel of the liquid coolers led 93
        /// </summary>
        CLLC_C1_93 = 854,

        /// <summary>
        /// For first channel of the liquid coolers led 94
        /// </summary>
        CLLC_C1_94 = 855,

        /// <summary>
        /// For first channel of the liquid coolers led 95
        /// </summary>
        CLLC_C1_95 = 856,

        /// <summary>
        /// For first channel of the liquid coolers led 96
        /// </summary>
        CLLC_C1_96 = 857,

        /// <summary>
        /// For first channel of the liquid coolers led 97
        /// </summary>
        CLLC_C1_97 = 858,

        /// <summary>
        /// For first channel of the liquid coolers led 98
        /// </summary>
        CLLC_C1_98 = 859,

        /// <summary>
        /// For first channel of the liquid coolers led 99
        /// </summary>
        CLLC_C1_99 = 860,

        /// <summary>
        /// For first channel of the liquid coolers led 100
        /// </summary>
        CLLC_C1_100 = 861,

        /// <summary>
        /// For first channel of the liquid coolers led 101
        /// </summary>
        CLLC_C1_101 = 862,

        /// <summary>
        /// For first channel of the liquid coolers led 102
        /// </summary>
        CLLC_C1_102 = 863,

        /// <summary>
        /// For first channel of the liquid coolers led 103
        /// </summary>
        CLLC_C1_103 = 864,

        /// <summary>
        /// For first channel of the liquid coolers led 104
        /// </summary>
        CLLC_C1_104 = 865,

        /// <summary>
        /// For first channel of the liquid coolers led 105
        /// </summary>
        CLLC_C1_105 = 866,

        /// <summary>
        /// For first channel of the liquid coolers led 106
        /// </summary>
        CLLC_C1_106 = 867,

        /// <summary>
        /// For first channel of the liquid coolers led 107
        /// </summary>
        CLLC_C1_107 = 868,

        /// <summary>
        /// For first channel of the liquid coolers led 108
        /// </summary>
        CLLC_C1_108 = 869,

        /// <summary>
        /// For first channel of the liquid coolers led 109
        /// </summary>
        CLLC_C1_109 = 870,

        /// <summary>
        /// For first channel of the liquid coolers led 110
        /// </summary>
        CLLC_C1_110 = 871,

        /// <summary>
        /// For first channel of the liquid coolers led 111
        /// </summary>
        CLLC_C1_111 = 872,

        /// <summary>
        /// For first channel of the liquid coolers led 112
        /// </summary>
        CLLC_C1_112 = 873,

        /// <summary>
        /// For first channel of the liquid coolers led 113
        /// </summary>
        CLLC_C1_113 = 874,

        /// <summary>
        /// For first channel of the liquid coolers led 114
        /// </summary>
        CLLC_C1_114 = 875,

        /// <summary>
        /// For first channel of the liquid coolers led 115
        /// </summary>
        CLLC_C1_115 = 876,

        /// <summary>
        /// For first channel of the liquid coolers led 116
        /// </summary>
        CLLC_C1_116 = 877,

        /// <summary>
        /// For first channel of the liquid coolers led 117
        /// </summary>
        CLLC_C1_117 = 878,

        /// <summary>
        /// For first channel of the liquid coolers led 118
        /// </summary>
        CLLC_C1_118 = 879,

        /// <summary>
        /// For first channel of the liquid coolers led 119
        /// </summary>
        CLLC_C1_119 = 880,

        /// <summary>
        /// For first channel of the liquid coolers led 120
        /// </summary>
        CLLC_C1_120 = 881,

        /// <summary>
        /// For first channel of the liquid coolers led 121
        /// </summary>
        CLLC_C1_121 = 882,

        /// <summary>
        /// For first channel of the liquid coolers led 122
        /// </summary>
        CLLC_C1_122 = 883,

        /// <summary>
        /// For first channel of the liquid coolers led 123
        /// </summary>
        CLLC_C1_123 = 884,

        /// <summary>
        /// For first channel of the liquid coolers led 124
        /// </summary>
        CLLC_C1_124 = 885,

        /// <summary>
        /// For first channel of the liquid coolers led 125
        /// </summary>
        CLLC_C1_125 = 886,

        /// <summary>
        /// For first channel of the liquid coolers led 126
        /// </summary>
        CLLC_C1_126 = 887,

        /// <summary>
        /// For first channel of the liquid coolers led 127
        /// </summary>
        CLLC_C1_127 = 888,

        /// <summary>
        /// For first channel of the liquid coolers led 128
        /// </summary>
        CLLC_C1_128 = 889,

        /// <summary>
        /// For first channel of the liquid coolers led 129
        /// </summary>
        CLLC_C1_129 = 890,

        /// <summary>
        /// For first channel of the liquid coolers led 130
        /// </summary>
        CLLC_C1_130 = 891,

        /// <summary>
        /// For first channel of the liquid coolers led 131
        /// </summary>
        CLLC_C1_131 = 892,

        /// <summary>
        /// For first channel of the liquid coolers led 132
        /// </summary>
        CLLC_C1_132 = 893,

        /// <summary>
        /// For first channel of the liquid coolers led 133
        /// </summary>
        CLLC_C1_133 = 894,

        /// <summary>
        /// For first channel of the liquid coolers led 134
        /// </summary>
        CLLC_C1_134 = 895,

        /// <summary>
        /// For first channel of the liquid coolers led 135
        /// </summary>
        CLLC_C1_135 = 896,

        /// <summary>
        /// For first channel of the liquid coolers led 136
        /// </summary>
        CLLC_C1_136 = 897,

        /// <summary>
        /// For first channel of the liquid coolers led 137
        /// </summary>
        CLLC_C1_137 = 898,

        /// <summary>
        /// For first channel of the liquid coolers led 138
        /// </summary>
        CLLC_C1_138 = 899,

        /// <summary>
        /// For first channel of the liquid coolers led 139
        /// </summary>
        CLLC_C1_139 = 900,

        /// <summary>
        /// For first channel of the liquid coolers led 140
        /// </summary>
        CLLC_C1_140 = 901,

        /// <summary>
        /// For first channel of the liquid coolers led 141
        /// </summary>
        CLLC_C1_141 = 902,

        /// <summary>
        /// For first channel of the liquid coolers led 142
        /// </summary>
        CLLC_C1_142 = 903,

        /// <summary>
        /// For first channel of the liquid coolers led 143
        /// </summary>
        CLLC_C1_143 = 904,

        /// <summary>
        /// For first channel of the liquid coolers led 144
        /// </summary>
        CLLC_C1_144 = 905,

        /// <summary>
        /// For first channel of the liquid coolers led 145
        /// </summary>
        CLLC_C1_145 = 906,

        /// <summary>
        /// For first channel of the liquid coolers led 146
        /// </summary>
        CLLC_C1_146 = 907,

        /// <summary>
        /// For first channel of the liquid coolers led 147
        /// </summary>
        CLLC_C1_147 = 908,

        /// <summary>
        /// For first channel of the liquid coolers led 148
        /// </summary>
        CLLC_C1_148 = 909,

        /// <summary>
        /// For first channel of the liquid coolers led 149
        /// </summary>
        CLLC_C1_149 = 910,

        /// <summary>
        /// For first channel of the liquid coolers led 150
        /// </summary>
        CLLC_C1_150 = 911,

        /// <summary>
        /// For first channel of the DIY-devices led 151
        /// </summary>
        CLD_C1_151 = 912,

        /// <summary>
        /// For first channel of the DIY-devices led 152
        /// </summary>
        CLD_C1_152 = 913,

        /// <summary>
        /// For first channel of the DIY-devices led 153
        /// </summary>
        CLD_C1_153 = 914,

        /// <summary>
        /// For first channel of the DIY-devices led 154
        /// </summary>
        CLD_C1_154 = 915,

        /// <summary>
        /// For first channel of the DIY-devices led 155
        /// </summary>
        CLD_C1_155 = 916,

        /// <summary>
        /// For first channel of the DIY-devices led 156
        /// </summary>
        CLD_C1_156 = 917,

        /// <summary>
        /// For first channel of the DIY-devices led 157
        /// </summary>
        CLD_C1_157 = 918,

        /// <summary>
        /// For first channel of the DIY-devices led 158
        /// </summary>
        CLD_C1_158 = 919,

        /// <summary>
        /// For first channel of the DIY-devices led 159
        /// </summary>
        CLD_C1_159 = 920,

        /// <summary>
        /// For first channel of the DIY-devices led 160
        /// </summary>
        CLD_C1_160 = 921,

        /// <summary>
        /// For first channel of the DIY-devices led 161
        /// </summary>
        CLD_C1_161 = 922,

        /// <summary>
        /// For first channel of the DIY-devices led 162
        /// </summary>
        CLD_C1_162 = 923,

        /// <summary>
        /// For first channel of the DIY-devices led 163
        /// </summary>
        CLD_C1_163 = 924,

        /// <summary>
        /// For first channel of the DIY-devices led 164
        /// </summary>
        CLD_C1_164 = 925,

        /// <summary>
        /// For first channel of the DIY-devices led 165
        /// </summary>
        CLD_C1_165 = 926,

        /// <summary>
        /// For first channel of the DIY-devices led 166
        /// </summary>
        CLD_C1_166 = 927,

        /// <summary>
        /// For first channel of the DIY-devices led 167
        /// </summary>
        CLD_C1_167 = 928,

        /// <summary>
        /// For first channel of the DIY-devices led 168
        /// </summary>
        CLD_C1_168 = 929,

        /// <summary>
        /// For first channel of the DIY-devices led 169
        /// </summary>
        CLD_C1_169 = 930,

        /// <summary>
        /// For first channel of the DIY-devices led 170
        /// </summary>
        CLD_C1_170 = 931,

        /// <summary>
        /// For first channel of the DIY-devices led 171
        /// </summary>
        CLD_C1_171 = 932,

        /// <summary>
        /// For first channel of the DIY-devices led 172
        /// </summary>
        CLD_C1_172 = 933,

        /// <summary>
        /// For first channel of the DIY-devices led 173
        /// </summary>
        CLD_C1_173 = 934,

        /// <summary>
        /// For first channel of the DIY-devices led 174
        /// </summary>
        CLD_C1_174 = 935,

        /// <summary>
        /// For first channel of the DIY-devices led 175
        /// </summary>
        CLD_C1_175 = 936,

        /// <summary>
        /// For first channel of the DIY-devices led 176
        /// </summary>
        CLD_C1_176 = 937,

        /// <summary>
        /// For first channel of the DIY-devices led 177
        /// </summary>
        CLD_C1_177 = 938,

        /// <summary>
        /// For first channel of the DIY-devices led 178
        /// </summary>
        CLD_C1_178 = 939,

        /// <summary>
        /// For first channel of the DIY-devices led 179
        /// </summary>
        CLD_C1_179 = 940,

        /// <summary>
        /// For first channel of the DIY-devices led 180
        /// </summary>
        CLD_C1_180 = 941,

        /// <summary>
        /// For first channel of the DIY-devices led 181
        /// </summary>
        CLD_C1_181 = 942,

        /// <summary>
        /// For first channel of the DIY-devices led 182
        /// </summary>
        CLD_C1_182 = 943,

        /// <summary>
        /// For first channel of the DIY-devices led 183
        /// </summary>
        CLD_C1_183 = 944,

        /// <summary>
        /// For first channel of the DIY-devices led 184
        /// </summary>
        CLD_C1_184 = 945,

        /// <summary>
        /// For first channel of the DIY-devices led 185
        /// </summary>
        CLD_C1_185 = 946,

        /// <summary>
        /// For first channel of the DIY-devices led 186
        /// </summary>
        CLD_C1_186 = 947,

        /// <summary>
        /// For first channel of the DIY-devices led 187
        /// </summary>
        CLD_C1_187 = 948,

        /// <summary>
        /// For first channel of the DIY-devices led 188
        /// </summary>
        CLD_C1_188 = 949,

        /// <summary>
        /// For first channel of the DIY-devices led 189
        /// </summary>
        CLD_C1_189 = 950,

        /// <summary>
        /// For first channel of the DIY-devices led 190
        /// </summary>
        CLD_C1_190 = 951,

        /// <summary>
        /// For first channel of the DIY-devices led 191
        /// </summary>
        CLD_C1_191 = 952,

        /// <summary>
        /// For first channel of the DIY-devices led 192
        /// </summary>
        CLD_C1_192 = 953,

        /// <summary>
        /// For first channel of the DIY-devices led 193
        /// </summary>
        CLD_C1_193 = 954,

        /// <summary>
        /// For first channel of the DIY-devices led 194
        /// </summary>
        CLD_C1_194 = 955,

        /// <summary>
        /// For first channel of the DIY-devices led 195
        /// </summary>
        CLD_C1_195 = 956,

        /// <summary>
        /// For first channel of the DIY-devices led 196
        /// </summary>
        CLD_C1_196 = 957,

        /// <summary>
        /// For first channel of the DIY-devices led 197
        /// </summary>
        CLD_C1_197 = 958,

        /// <summary>
        /// For first channel of the DIY-devices led 198
        /// </summary>
        CLD_C1_198 = 959,

        /// <summary>
        /// For first channel of the DIY-devices led 199
        /// </summary>
        CLD_C1_199 = 960,

        /// <summary>
        /// For first channel of the DIY-devices led 200
        /// </summary>
        CLD_C1_200 = 961,

        /// <summary>
        /// For first channel of the DIY-devices led 201
        /// </summary>
        CLD_C1_201 = 962,

        /// <summary>
        /// For first channel of the DIY-devices led 202
        /// </summary>
        CLD_C1_202 = 963,

        /// <summary>
        /// For first channel of the DIY-devices led 203
        /// </summary>
        CLD_C1_203 = 964,

        /// <summary>
        /// For first channel of the DIY-devices led 204
        /// </summary>
        CLD_C1_204 = 965,

        /// <summary>
        /// For first channel of the DIY-devices led 205
        /// </summary>
        CLD_C1_205 = 966,

        /// <summary>
        /// For first channel of the DIY-devices led 206
        /// </summary>
        CLD_C1_206 = 967,

        /// <summary>
        /// For first channel of the DIY-devices led 207
        /// </summary>
        CLD_C1_207 = 968,

        /// <summary>
        /// For first channel of the DIY-devices led 208
        /// </summary>
        CLD_C1_208 = 969,

        /// <summary>
        /// For first channel of the DIY-devices led 209
        /// </summary>
        CLD_C1_209 = 970,

        /// <summary>
        /// For first channel of the DIY-devices led 210
        /// </summary>
        CLD_C1_210 = 971,

        /// <summary>
        /// For first channel of the DIY-devices led 211
        /// </summary>
        CLD_C1_211 = 972,

        /// <summary>
        /// For first channel of the DIY-devices led 212
        /// </summary>
        CLD_C1_212 = 973,

        /// <summary>
        /// For first channel of the DIY-devices led 213
        /// </summary>
        CLD_C1_213 = 974,

        /// <summary>
        /// For first channel of the DIY-devices led 214
        /// </summary>
        CLD_C1_214 = 975,

        /// <summary>
        /// For first channel of the DIY-devices led 215
        /// </summary>
        CLD_C1_215 = 976,

        /// <summary>
        /// For first channel of the DIY-devices led 216
        /// </summary>
        CLD_C1_216 = 977,

        /// <summary>
        /// For first channel of the DIY-devices led 217
        /// </summary>
        CLD_C1_217 = 978,

        /// <summary>
        /// For first channel of the DIY-devices led 218
        /// </summary>
        CLD_C1_218 = 979,

        /// <summary>
        /// For first channel of the DIY-devices led 219
        /// </summary>
        CLD_C1_219 = 980,

        /// <summary>
        /// For first channel of the DIY-devices led 220
        /// </summary>
        CLD_C1_220 = 981,

        /// <summary>
        /// For first channel of the DIY-devices led 221
        /// </summary>
        CLD_C1_221 = 982,

        /// <summary>
        /// For first channel of the DIY-devices led 222
        /// </summary>
        CLD_C1_222 = 983,

        /// <summary>
        /// For first channel of the DIY-devices led 223
        /// </summary>
        CLD_C1_223 = 984,

        /// <summary>
        /// For first channel of the DIY-devices led 224
        /// </summary>
        CLD_C1_224 = 985,

        /// <summary>
        /// For first channel of the DIY-devices led 225
        /// </summary>
        CLD_C1_225 = 986,

        /// <summary>
        /// For first channel of the DIY-devices led 226
        /// </summary>
        CLD_C1_226 = 987,

        /// <summary>
        /// For first channel of the DIY-devices led 227
        /// </summary>
        CLD_C1_227 = 988,

        /// <summary>
        /// For first channel of the DIY-devices led 228
        /// </summary>
        CLD_C1_228 = 989,

        /// <summary>
        /// For first channel of the DIY-devices led 229
        /// </summary>
        CLD_C1_229 = 990,

        /// <summary>
        /// For first channel of the DIY-devices led 230
        /// </summary>
        CLD_C1_230 = 991,

        /// <summary>
        /// For first channel of the DIY-devices led 231
        /// </summary>
        CLD_C1_231 = 992,

        /// <summary>
        /// For first channel of the DIY-devices led 232
        /// </summary>
        CLD_C1_232 = 993,

        /// <summary>
        /// For first channel of the DIY-devices led 233
        /// </summary>
        CLD_C1_233 = 994,

        /// <summary>
        /// For first channel of the DIY-devices led 234
        /// </summary>
        CLD_C1_234 = 995,

        /// <summary>
        /// For first channel of the DIY-devices led 235
        /// </summary>
        CLD_C1_235 = 996,

        /// <summary>
        /// For first channel of the DIY-devices led 236
        /// </summary>
        CLD_C1_236 = 997,

        /// <summary>
        /// For first channel of the DIY-devices led 237
        /// </summary>
        CLD_C1_237 = 998,

        /// <summary>
        /// For first channel of the DIY-devices led 238
        /// </summary>
        CLD_C1_238 = 999,

        /// <summary>
        /// For first channel of the DIY-devices led 239
        /// </summary>
        CLD_C1_239 = 1000,

        /// <summary>
        /// For first channel of the DIY-devices led 240
        /// </summary>
        CLD_C1_240 = 1001,

        /// <summary>
        /// For first channel of the DIY-devices led 241
        /// </summary>
        CLD_C1_241 = 1002,

        /// <summary>
        /// For first channel of the DIY-devices led 242
        /// </summary>
        CLD_C1_242 = 1003,

        /// <summary>
        /// For first channel of the DIY-devices led 243
        /// </summary>
        CLD_C1_243 = 1004,

        /// <summary>
        /// For first channel of the DIY-devices led 244
        /// </summary>
        CLD_C1_244 = 1005,

        /// <summary>
        /// For first channel of the DIY-devices led 245
        /// </summary>
        CLD_C1_245 = 1006,

        /// <summary>
        /// For first channel of the DIY-devices led 246
        /// </summary>
        CLD_C1_246 = 1007,

        /// <summary>
        /// For first channel of the DIY-devices led 247
        /// </summary>
        CLD_C1_247 = 1008,

        /// <summary>
        /// For first channel of the DIY-devices led 248
        /// </summary>
        CLD_C1_248 = 1009,

        /// <summary>
        /// For first channel of the DIY-devices led 249
        /// </summary>
        CLD_C1_249 = 1010,

        /// <summary>
        /// For first channel of the DIY-devices led 250
        /// </summary>
        CLD_C1_250 = 1011,

        /// <summary>
        /// For first channel of the DIY-devices led 251
        /// </summary>
        CLD_C1_251 = 1012,

        /// <summary>
        /// For first channel of the DIY-devices led 252
        /// </summary>
        CLD_C1_252 = 1013,

        /// <summary>
        /// For first channel of the DIY-devices led 253
        /// </summary>
        CLD_C1_253 = 1014,

        /// <summary>
        /// For first channel of the DIY-devices led 254
        /// </summary>
        CLD_C1_254 = 1015,

        /// <summary>
        /// For first channel of the DIY-devices led 255
        /// </summary>
        CLD_C1_255 = 1016,

        /// <summary>
        /// For first channel of the DIY-devices led 256
        /// </summary>
        CLD_C1_256 = 1017,

        /// <summary>
        /// For first channel of the DIY-devices led 257
        /// </summary>
        CLD_C1_257 = 1018,

        /// <summary>
        /// For first channel of the DIY-devices led 258
        /// </summary>
        CLD_C1_258 = 1019,

        /// <summary>
        /// For first channel of the DIY-devices led 259
        /// </summary>
        CLD_C1_259 = 1020,

        /// <summary>
        /// For first channel of the DIY-devices led 260
        /// </summary>
        CLD_C1_260 = 1021,

        /// <summary>
        /// For first channel of the DIY-devices led 261
        /// </summary>
        CLD_C1_261 = 1022,

        /// <summary>
        /// For first channel of the DIY-devices led 262
        /// </summary>
        CLD_C1_262 = 1023,

        /// <summary>
        /// For first channel of the DIY-devices led 263
        /// </summary>
        CLD_C1_263 = 1024,

        /// <summary>
        /// For first channel of the DIY-devices led 264
        /// </summary>
        CLD_C1_264 = 1025,

        /// <summary>
        /// For first channel of the DIY-devices led 265
        /// </summary>
        CLD_C1_265 = 1026,

        /// <summary>
        /// For first channel of the DIY-devices led 266
        /// </summary>
        CLD_C1_266 = 1027,

        /// <summary>
        /// For first channel of the DIY-devices led 267
        /// </summary>
        CLD_C1_267 = 1028,

        /// <summary>
        /// For first channel of the DIY-devices led 268
        /// </summary>
        CLD_C1_268 = 1029,

        /// <summary>
        /// For first channel of the DIY-devices led 269
        /// </summary>
        CLD_C1_269 = 1030,

        /// <summary>
        /// For first channel of the DIY-devices led 270
        /// </summary>
        CLD_C1_270 = 1031,

        /// <summary>
        /// For first channel of the DIY-devices led 271
        /// </summary>
        CLD_C1_271 = 1032,

        /// <summary>
        /// For first channel of the DIY-devices led 272
        /// </summary>
        CLD_C1_272 = 1033,

        /// <summary>
        /// For first channel of the DIY-devices led 273
        /// </summary>
        CLD_C1_273 = 1034,

        /// <summary>
        /// For first channel of the DIY-devices led 274
        /// </summary>
        CLD_C1_274 = 1035,

        /// <summary>
        /// For first channel of the DIY-devices led 275
        /// </summary>
        CLD_C1_275 = 1036,

        /// <summary>
        /// For first channel of the DIY-devices led 276
        /// </summary>
        CLD_C1_276 = 1037,

        /// <summary>
        /// For first channel of the DIY-devices led 277
        /// </summary>
        CLD_C1_277 = 1038,

        /// <summary>
        /// For first channel of the DIY-devices led 278
        /// </summary>
        CLD_C1_278 = 1039,

        /// <summary>
        /// For first channel of the DIY-devices led 279
        /// </summary>
        CLD_C1_279 = 1040,

        /// <summary>
        /// For first channel of the DIY-devices led 280
        /// </summary>
        CLD_C1_280 = 1041,

        /// <summary>
        /// For first channel of the DIY-devices led 281
        /// </summary>
        CLD_C1_281 = 1042,

        /// <summary>
        /// For first channel of the DIY-devices led 282
        /// </summary>
        CLD_C1_282 = 1043,

        /// <summary>
        /// For first channel of the DIY-devices led 283
        /// </summary>
        CLD_C1_283 = 1044,

        /// <summary>
        /// For first channel of the DIY-devices led 284
        /// </summary>
        CLD_C1_284 = 1045,

        /// <summary>
        /// For first channel of the DIY-devices led 285
        /// </summary>
        CLD_C1_285 = 1046,

        /// <summary>
        /// For first channel of the DIY-devices led 286
        /// </summary>
        CLD_C1_286 = 1047,

        /// <summary>
        /// For first channel of the DIY-devices led 287
        /// </summary>
        CLD_C1_287 = 1048,

        /// <summary>
        /// For first channel of the DIY-devices led 288
        /// </summary>
        CLD_C1_288 = 1049,

        /// <summary>
        /// For first channel of the DIY-devices led 289
        /// </summary>
        CLD_C1_289 = 1050,

        /// <summary>
        /// For first channel of the DIY-devices led 290
        /// </summary>
        CLD_C1_290 = 1051,

        /// <summary>
        /// For first channel of the DIY-devices led 291
        /// </summary>
        CLD_C1_291 = 1052,

        /// <summary>
        /// For first channel of the DIY-devices led 292
        /// </summary>
        CLD_C1_292 = 1053,

        /// <summary>
        /// For first channel of the DIY-devices led 293
        /// </summary>
        CLD_C1_293 = 1054,

        /// <summary>
        /// For first channel of the DIY-devices led 294
        /// </summary>
        CLD_C1_294 = 1055,

        /// <summary>
        /// For first channel of the DIY-devices led 295
        /// </summary>
        CLD_C1_295 = 1056,

        /// <summary>
        /// For first channel of the DIY-devices led 296
        /// </summary>
        CLD_C1_296 = 1057,

        /// <summary>
        /// For first channel of the DIY-devices led 297
        /// </summary>
        CLD_C1_297 = 1058,

        /// <summary>
        /// For first channel of the DIY-devices led 298
        /// </summary>
        CLD_C1_298 = 1059,

        /// <summary>
        /// For first channel of the DIY-devices led 299
        /// </summary>
        CLD_C1_299 = 1060,

        /// <summary>
        /// For first channel of the DIY-devices led 300
        /// </summary>
        CLD_C1_300 = 1061,

        /// <summary>
        /// For second channel of the DIY-devices led 151
        /// </summary>
        CLD_C2_151 = 1062,

        /// <summary>
        /// For second channel of the DIY-devices led 152
        /// </summary>
        CLD_C2_152 = 1063,

        /// <summary>
        /// For second channel of the DIY-devices led 153
        /// </summary>
        CLD_C2_153 = 1064,

        /// <summary>
        /// For second channel of the DIY-devices led 154
        /// </summary>
        CLD_C2_154 = 1065,

        /// <summary>
        /// For second channel of the DIY-devices led 155
        /// </summary>
        CLD_C2_155 = 1066,

        /// <summary>
        /// For second channel of the DIY-devices led 156
        /// </summary>
        CLD_C2_156 = 1067,

        /// <summary>
        /// For second channel of the DIY-devices led 157
        /// </summary>
        CLD_C2_157 = 1068,

        /// <summary>
        /// For second channel of the DIY-devices led 158
        /// </summary>
        CLD_C2_158 = 1069,

        /// <summary>
        /// For second channel of the DIY-devices led 159
        /// </summary>
        CLD_C2_159 = 1070,

        /// <summary>
        /// For second channel of the DIY-devices led 160
        /// </summary>
        CLD_C2_160 = 1071,

        /// <summary>
        /// For second channel of the DIY-devices led 161
        /// </summary>
        CLD_C2_161 = 1072,

        /// <summary>
        /// For second channel of the DIY-devices led 162
        /// </summary>
        CLD_C2_162 = 1073,

        /// <summary>
        /// For second channel of the DIY-devices led 163
        /// </summary>
        CLD_C2_163 = 1074,

        /// <summary>
        /// For second channel of the DIY-devices led 164
        /// </summary>
        CLD_C2_164 = 1075,

        /// <summary>
        /// For second channel of the DIY-devices led 165
        /// </summary>
        CLD_C2_165 = 1076,

        /// <summary>
        /// For second channel of the DIY-devices led 166
        /// </summary>
        CLD_C2_166 = 1077,

        /// <summary>
        /// For second channel of the DIY-devices led 167
        /// </summary>
        CLD_C2_167 = 1078,

        /// <summary>
        /// For second channel of the DIY-devices led 168
        /// </summary>
        CLD_C2_168 = 1079,

        /// <summary>
        /// For second channel of the DIY-devices led 169
        /// </summary>
        CLD_C2_169 = 1080,

        /// <summary>
        /// For second channel of the DIY-devices led 170
        /// </summary>
        CLD_C2_170 = 1081,

        /// <summary>
        /// For second channel of the DIY-devices led 171
        /// </summary>
        CLD_C2_171 = 1082,

        /// <summary>
        /// For second channel of the DIY-devices led 172
        /// </summary>
        CLD_C2_172 = 1083,

        /// <summary>
        /// For second channel of the DIY-devices led 173
        /// </summary>
        CLD_C2_173 = 1084,

        /// <summary>
        /// For second channel of the DIY-devices led 174
        /// </summary>
        CLD_C2_174 = 1085,

        /// <summary>
        /// For second channel of the DIY-devices led 175
        /// </summary>
        CLD_C2_175 = 1086,

        /// <summary>
        /// For second channel of the DIY-devices led 176
        /// </summary>
        CLD_C2_176 = 1087,

        /// <summary>
        /// For second channel of the DIY-devices led 177
        /// </summary>
        CLD_C2_177 = 1088,

        /// <summary>
        /// For second channel of the DIY-devices led 178
        /// </summary>
        CLD_C2_178 = 1089,

        /// <summary>
        /// For second channel of the DIY-devices led 179
        /// </summary>
        CLD_C2_179 = 1090,

        /// <summary>
        /// For second channel of the DIY-devices led 180
        /// </summary>
        CLD_C2_180 = 1091,

        /// <summary>
        /// For second channel of the DIY-devices led 181
        /// </summary>
        CLD_C2_181 = 1092,

        /// <summary>
        /// For second channel of the DIY-devices led 182
        /// </summary>
        CLD_C2_182 = 1093,

        /// <summary>
        /// For second channel of the DIY-devices led 183
        /// </summary>
        CLD_C2_183 = 1094,

        /// <summary>
        /// For second channel of the DIY-devices led 184
        /// </summary>
        CLD_C2_184 = 1095,

        /// <summary>
        /// For second channel of the DIY-devices led 185
        /// </summary>
        CLD_C2_185 = 1096,

        /// <summary>
        /// For second channel of the DIY-devices led 186
        /// </summary>
        CLD_C2_186 = 1097,

        /// <summary>
        /// For second channel of the DIY-devices led 187
        /// </summary>
        CLD_C2_187 = 1098,

        /// <summary>
        /// For second channel of the DIY-devices led 188
        /// </summary>
        CLD_C2_188 = 1099,

        /// <summary>
        /// For second channel of the DIY-devices led 189
        /// </summary>
        CLD_C2_189 = 1100,

        /// <summary>
        /// For second channel of the DIY-devices led 190
        /// </summary>
        CLD_C2_190 = 1101,

        /// <summary>
        /// For second channel of the DIY-devices led 191
        /// </summary>
        CLD_C2_191 = 1102,

        /// <summary>
        /// For second channel of the DIY-devices led 192
        /// </summary>
        CLD_C2_192 = 1103,

        /// <summary>
        /// For second channel of the DIY-devices led 193
        /// </summary>
        CLD_C2_193 = 1104,

        /// <summary>
        /// For second channel of the DIY-devices led 194
        /// </summary>
        CLD_C2_194 = 1105,

        /// <summary>
        /// For second channel of the DIY-devices led 195
        /// </summary>
        CLD_C2_195 = 1106,

        /// <summary>
        /// For second channel of the DIY-devices led 196
        /// </summary>
        CLD_C2_196 = 1107,

        /// <summary>
        /// For second channel of the DIY-devices led 197
        /// </summary>
        CLD_C2_197 = 1108,

        /// <summary>
        /// For second channel of the DIY-devices led 198
        /// </summary>
        CLD_C2_198 = 1109,

        /// <summary>
        /// For second channel of the DIY-devices led 199
        /// </summary>
        CLD_C2_199 = 1110,

        /// <summary>
        /// For second channel of the DIY-devices led 200
        /// </summary>
        CLD_C2_200 = 1111,

        /// <summary>
        /// For second channel of the DIY-devices led 201
        /// </summary>
        CLD_C2_201 = 1112,

        /// <summary>
        /// For second channel of the DIY-devices led 202
        /// </summary>
        CLD_C2_202 = 1113,

        /// <summary>
        /// For second channel of the DIY-devices led 203
        /// </summary>
        CLD_C2_203 = 1114,

        /// <summary>
        /// For second channel of the DIY-devices led 204
        /// </summary>
        CLD_C2_204 = 1115,

        /// <summary>
        /// For second channel of the DIY-devices led 205
        /// </summary>
        CLD_C2_205 = 1116,

        /// <summary>
        /// For second channel of the DIY-devices led 206
        /// </summary>
        CLD_C2_206 = 1117,

        /// <summary>
        /// For second channel of the DIY-devices led 207
        /// </summary>
        CLD_C2_207 = 1118,

        /// <summary>
        /// For second channel of the DIY-devices led 208
        /// </summary>
        CLD_C2_208 = 1119,

        /// <summary>
        /// For second channel of the DIY-devices led 209
        /// </summary>
        CLD_C2_209 = 1120,

        /// <summary>
        /// For second channel of the DIY-devices led 210
        /// </summary>
        CLD_C2_210 = 1121,

        /// <summary>
        /// For second channel of the DIY-devices led 211
        /// </summary>
        CLD_C2_211 = 1122,

        /// <summary>
        /// For second channel of the DIY-devices led 212
        /// </summary>
        CLD_C2_212 = 1123,

        /// <summary>
        /// For second channel of the DIY-devices led 213
        /// </summary>
        CLD_C2_213 = 1124,

        /// <summary>
        /// For second channel of the DIY-devices led 214
        /// </summary>
        CLD_C2_214 = 1125,

        /// <summary>
        /// For second channel of the DIY-devices led 215
        /// </summary>
        CLD_C2_215 = 1126,

        /// <summary>
        /// For second channel of the DIY-devices led 216
        /// </summary>
        CLD_C2_216 = 1127,

        /// <summary>
        /// For second channel of the DIY-devices led 217
        /// </summary>
        CLD_C2_217 = 1128,

        /// <summary>
        /// For second channel of the DIY-devices led 218
        /// </summary>
        CLD_C2_218 = 1129,

        /// <summary>
        /// For second channel of the DIY-devices led 219
        /// </summary>
        CLD_C2_219 = 1130,

        /// <summary>
        /// For second channel of the DIY-devices led 220
        /// </summary>
        CLD_C2_220 = 1131,

        /// <summary>
        /// For second channel of the DIY-devices led 221
        /// </summary>
        CLD_C2_221 = 1132,

        /// <summary>
        /// For second channel of the DIY-devices led 222
        /// </summary>
        CLD_C2_222 = 1133,

        /// <summary>
        /// For second channel of the DIY-devices led 223
        /// </summary>
        CLD_C2_223 = 1134,

        /// <summary>
        /// For second channel of the DIY-devices led 224
        /// </summary>
        CLD_C2_224 = 1135,

        /// <summary>
        /// For second channel of the DIY-devices led 225
        /// </summary>
        CLD_C2_225 = 1136,

        /// <summary>
        /// For second channel of the DIY-devices led 226
        /// </summary>
        CLD_C2_226 = 1137,

        /// <summary>
        /// For second channel of the DIY-devices led 227
        /// </summary>
        CLD_C2_227 = 1138,

        /// <summary>
        /// For second channel of the DIY-devices led 228
        /// </summary>
        CLD_C2_228 = 1139,

        /// <summary>
        /// For second channel of the DIY-devices led 229
        /// </summary>
        CLD_C2_229 = 1140,

        /// <summary>
        /// For second channel of the DIY-devices led 230
        /// </summary>
        CLD_C2_230 = 1141,

        /// <summary>
        /// For second channel of the DIY-devices led 231
        /// </summary>
        CLD_C2_231 = 1142,

        /// <summary>
        /// For second channel of the DIY-devices led 232
        /// </summary>
        CLD_C2_232 = 1143,

        /// <summary>
        /// For second channel of the DIY-devices led 233
        /// </summary>
        CLD_C2_233 = 1144,

        /// <summary>
        /// For second channel of the DIY-devices led 234
        /// </summary>
        CLD_C2_234 = 1145,

        /// <summary>
        /// For second channel of the DIY-devices led 235
        /// </summary>
        CLD_C2_235 = 1146,

        /// <summary>
        /// For second channel of the DIY-devices led 236
        /// </summary>
        CLD_C2_236 = 1147,

        /// <summary>
        /// For second channel of the DIY-devices led 237
        /// </summary>
        CLD_C2_237 = 1148,

        /// <summary>
        /// For second channel of the DIY-devices led 238
        /// </summary>
        CLD_C2_238 = 1149,

        /// <summary>
        /// For second channel of the DIY-devices led 239
        /// </summary>
        CLD_C2_239 = 1150,

        /// <summary>
        /// For second channel of the DIY-devices led 240
        /// </summary>
        CLD_C2_240 = 1151,

        /// <summary>
        /// For second channel of the DIY-devices led 241
        /// </summary>
        CLD_C2_241 = 1152,

        /// <summary>
        /// For second channel of the DIY-devices led 242
        /// </summary>
        CLD_C2_242 = 1153,

        /// <summary>
        /// For second channel of the DIY-devices led 243
        /// </summary>
        CLD_C2_243 = 1154,

        /// <summary>
        /// For second channel of the DIY-devices led 244
        /// </summary>
        CLD_C2_244 = 1155,

        /// <summary>
        /// For second channel of the DIY-devices led 245
        /// </summary>
        CLD_C2_245 = 1156,

        /// <summary>
        /// For second channel of the DIY-devices led 246
        /// </summary>
        CLD_C2_246 = 1157,

        /// <summary>
        /// For second channel of the DIY-devices led 247
        /// </summary>
        CLD_C2_247 = 1158,

        /// <summary>
        /// For second channel of the DIY-devices led 248
        /// </summary>
        CLD_C2_248 = 1159,

        /// <summary>
        /// For second channel of the DIY-devices led 249
        /// </summary>
        CLD_C2_249 = 1160,

        /// <summary>
        /// For second channel of the DIY-devices led 250
        /// </summary>
        CLD_C2_250 = 1161,

        /// <summary>
        /// For second channel of the DIY-devices led 251
        /// </summary>
        CLD_C2_251 = 1162,

        /// <summary>
        /// For second channel of the DIY-devices led 252
        /// </summary>
        CLD_C2_252 = 1163,

        /// <summary>
        /// For second channel of the DIY-devices led 253
        /// </summary>
        CLD_C2_253 = 1164,

        /// <summary>
        /// For second channel of the DIY-devices led 254
        /// </summary>
        CLD_C2_254 = 1165,

        /// <summary>
        /// For second channel of the DIY-devices led 255
        /// </summary>
        CLD_C2_255 = 1166,

        /// <summary>
        /// For second channel of the DIY-devices led 256
        /// </summary>
        CLD_C2_256 = 1167,

        /// <summary>
        /// For second channel of the DIY-devices led 257
        /// </summary>
        CLD_C2_257 = 1168,

        /// <summary>
        /// For second channel of the DIY-devices led 258
        /// </summary>
        CLD_C2_258 = 1169,

        /// <summary>
        /// For second channel of the DIY-devices led 259
        /// </summary>
        CLD_C2_259 = 1170,

        /// <summary>
        /// For second channel of the DIY-devices led 260
        /// </summary>
        CLD_C2_260 = 1171,

        /// <summary>
        /// For second channel of the DIY-devices led 261
        /// </summary>
        CLD_C2_261 = 1172,

        /// <summary>
        /// For second channel of the DIY-devices led 262
        /// </summary>
        CLD_C2_262 = 1173,

        /// <summary>
        /// For second channel of the DIY-devices led 263
        /// </summary>
        CLD_C2_263 = 1174,

        /// <summary>
        /// For second channel of the DIY-devices led 264
        /// </summary>
        CLD_C2_264 = 1175,

        /// <summary>
        /// For second channel of the DIY-devices led 265
        /// </summary>
        CLD_C2_265 = 1176,

        /// <summary>
        /// For second channel of the DIY-devices led 266
        /// </summary>
        CLD_C2_266 = 1177,

        /// <summary>
        /// For second channel of the DIY-devices led 267
        /// </summary>
        CLD_C2_267 = 1178,

        /// <summary>
        /// For second channel of the DIY-devices led 268
        /// </summary>
        CLD_C2_268 = 1179,

        /// <summary>
        /// For second channel of the DIY-devices led 269
        /// </summary>
        CLD_C2_269 = 1180,

        /// <summary>
        /// For second channel of the DIY-devices led 270
        /// </summary>
        CLD_C2_270 = 1181,

        /// <summary>
        /// For second channel of the DIY-devices led 271
        /// </summary>
        CLD_C2_271 = 1182,

        /// <summary>
        /// For second channel of the DIY-devices led 272
        /// </summary>
        CLD_C2_272 = 1183,

        /// <summary>
        /// For second channel of the DIY-devices led 273
        /// </summary>
        CLD_C2_273 = 1184,

        /// <summary>
        /// For second channel of the DIY-devices led 274
        /// </summary>
        CLD_C2_274 = 1185,

        /// <summary>
        /// For second channel of the DIY-devices led 275
        /// </summary>
        CLD_C2_275 = 1186,

        /// <summary>
        /// For second channel of the DIY-devices led 276
        /// </summary>
        CLD_C2_276 = 1187,

        /// <summary>
        /// For second channel of the DIY-devices led 277
        /// </summary>
        CLD_C2_277 = 1188,

        /// <summary>
        /// For second channel of the DIY-devices led 278
        /// </summary>
        CLD_C2_278 = 1189,

        /// <summary>
        /// For second channel of the DIY-devices led 279
        /// </summary>
        CLD_C2_279 = 1190,

        /// <summary>
        /// For second channel of the DIY-devices led 280
        /// </summary>
        CLD_C2_280 = 1191,

        /// <summary>
        /// For second channel of the DIY-devices led 281
        /// </summary>
        CLD_C2_281 = 1192,

        /// <summary>
        /// For second channel of the DIY-devices led 282
        /// </summary>
        CLD_C2_282 = 1193,

        /// <summary>
        /// For second channel of the DIY-devices led 283
        /// </summary>
        CLD_C2_283 = 1194,

        /// <summary>
        /// For second channel of the DIY-devices led 284
        /// </summary>
        CLD_C2_284 = 1195,

        /// <summary>
        /// For second channel of the DIY-devices led 285
        /// </summary>
        CLD_C2_285 = 1196,

        /// <summary>
        /// For second channel of the DIY-devices led 286
        /// </summary>
        CLD_C2_286 = 1197,

        /// <summary>
        /// For second channel of the DIY-devices led 287
        /// </summary>
        CLD_C2_287 = 1198,

        /// <summary>
        /// For second channel of the DIY-devices led 288
        /// </summary>
        CLD_C2_288 = 1199,

        /// <summary>
        /// For second channel of the DIY-devices led 289
        /// </summary>
        CLD_C2_289 = 1200,

        /// <summary>
        /// For second channel of the DIY-devices led 290
        /// </summary>
        CLD_C2_290 = 1201,

        /// <summary>
        /// For second channel of the DIY-devices led 291
        /// </summary>
        CLD_C2_291 = 1202,

        /// <summary>
        /// For second channel of the DIY-devices led 292
        /// </summary>
        CLD_C2_292 = 1203,

        /// <summary>
        /// For second channel of the DIY-devices led 293
        /// </summary>
        CLD_C2_293 = 1204,

        /// <summary>
        /// For second channel of the DIY-devices led 294
        /// </summary>
        CLD_C2_294 = 1205,

        /// <summary>
        /// For second channel of the DIY-devices led 295
        /// </summary>
        CLD_C2_295 = 1206,

        /// <summary>
        /// For second channel of the DIY-devices led 296
        /// </summary>
        CLD_C2_296 = 1207,

        /// <summary>
        /// For second channel of the DIY-devices led 297
        /// </summary>
        CLD_C2_297 = 1208,

        /// <summary>
        /// For second channel of the DIY-devices led 298
        /// </summary>
        CLD_C2_298 = 1209,

        /// <summary>
        /// For second channel of the DIY-devices led 299
        /// </summary>
        CLD_C2_299 = 1210,

        /// <summary>
        /// For second channel of the DIY-devices led 300
        /// </summary>
        CLD_C2_300 = 1211,

        /// <summary>
        /// For third channel of the DIY-devices led 151
        /// </summary>
        CLD_C3_151 = 1212,

        /// <summary>
        /// For third channel of the DIY-devices led 152
        /// </summary>
        CLD_C3_152 = 1213,

        /// <summary>
        /// For third channel of the DIY-devices led 153
        /// </summary>
        CLD_C3_153 = 1214,

        /// <summary>
        /// For third channel of the DIY-devices led 154
        /// </summary>
        CLD_C3_154 = 1215,

        /// <summary>
        /// For third channel of the DIY-devices led 155
        /// </summary>
        CLD_C3_155 = 1216,

        /// <summary>
        /// For third channel of the DIY-devices led 156
        /// </summary>
        CLD_C3_156 = 1217,

        /// <summary>
        /// For third channel of the DIY-devices led 157
        /// </summary>
        CLD_C3_157 = 1218,

        /// <summary>
        /// For third channel of the DIY-devices led 158
        /// </summary>
        CLD_C3_158 = 1219,

        /// <summary>
        /// For third channel of the DIY-devices led 159
        /// </summary>
        CLD_C3_159 = 1220,

        /// <summary>
        /// For third channel of the DIY-devices led 160
        /// </summary>
        CLD_C3_160 = 1221,

        /// <summary>
        /// For third channel of the DIY-devices led 161
        /// </summary>
        CLD_C3_161 = 1222,

        /// <summary>
        /// For third channel of the DIY-devices led 162
        /// </summary>
        CLD_C3_162 = 1223,

        /// <summary>
        /// For third channel of the DIY-devices led 163
        /// </summary>
        CLD_C3_163 = 1224,

        /// <summary>
        /// For third channel of the DIY-devices led 164
        /// </summary>
        CLD_C3_164 = 1225,

        /// <summary>
        /// For third channel of the DIY-devices led 165
        /// </summary>
        CLD_C3_165 = 1226,

        /// <summary>
        /// For third channel of the DIY-devices led 166
        /// </summary>
        CLD_C3_166 = 1227,

        /// <summary>
        /// For third channel of the DIY-devices led 167
        /// </summary>
        CLD_C3_167 = 1228,

        /// <summary>
        /// For third channel of the DIY-devices led 168
        /// </summary>
        CLD_C3_168 = 1229,

        /// <summary>
        /// For third channel of the DIY-devices led 169
        /// </summary>
        CLD_C3_169 = 1230,

        /// <summary>
        /// For third channel of the DIY-devices led 170
        /// </summary>
        CLD_C3_170 = 1231,

        /// <summary>
        /// For third channel of the DIY-devices led 171
        /// </summary>
        CLD_C3_171 = 1232,

        /// <summary>
        /// For third channel of the DIY-devices led 172
        /// </summary>
        CLD_C3_172 = 1233,

        /// <summary>
        /// For third channel of the DIY-devices led 173
        /// </summary>
        CLD_C3_173 = 1234,

        /// <summary>
        /// For third channel of the DIY-devices led 174
        /// </summary>
        CLD_C3_174 = 1235,

        /// <summary>
        /// For third channel of the DIY-devices led 175
        /// </summary>
        CLD_C3_175 = 1236,

        /// <summary>
        /// For third channel of the DIY-devices led 176
        /// </summary>
        CLD_C3_176 = 1237,

        /// <summary>
        /// For third channel of the DIY-devices led 177
        /// </summary>
        CLD_C3_177 = 1238,

        /// <summary>
        /// For third channel of the DIY-devices led 178
        /// </summary>
        CLD_C3_178 = 1239,

        /// <summary>
        /// For third channel of the DIY-devices led 179
        /// </summary>
        CLD_C3_179 = 1240,

        /// <summary>
        /// For third channel of the DIY-devices led 180
        /// </summary>
        CLD_C3_180 = 1241,

        /// <summary>
        /// For third channel of the DIY-devices led 181
        /// </summary>
        CLD_C3_181 = 1242,

        /// <summary>
        /// For third channel of the DIY-devices led 182
        /// </summary>
        CLD_C3_182 = 1243,

        /// <summary>
        /// For third channel of the DIY-devices led 183
        /// </summary>
        CLD_C3_183 = 1244,

        /// <summary>
        /// For third channel of the DIY-devices led 184
        /// </summary>
        CLD_C3_184 = 1245,

        /// <summary>
        /// For third channel of the DIY-devices led 185
        /// </summary>
        CLD_C3_185 = 1246,

        /// <summary>
        /// For third channel of the DIY-devices led 186
        /// </summary>
        CLD_C3_186 = 1247,

        /// <summary>
        /// For third channel of the DIY-devices led 187
        /// </summary>
        CLD_C3_187 = 1248,

        /// <summary>
        /// For third channel of the DIY-devices led 188
        /// </summary>
        CLD_C3_188 = 1249,

        /// <summary>
        /// For third channel of the DIY-devices led 189
        /// </summary>
        CLD_C3_189 = 1250,

        /// <summary>
        /// For third channel of the DIY-devices led 190
        /// </summary>
        CLD_C3_190 = 1251,

        /// <summary>
        /// For third channel of the DIY-devices led 191
        /// </summary>
        CLD_C3_191 = 1252,

        /// <summary>
        /// For third channel of the DIY-devices led 192
        /// </summary>
        CLD_C3_192 = 1253,

        /// <summary>
        /// For third channel of the DIY-devices led 193
        /// </summary>
        CLD_C3_193 = 1254,

        /// <summary>
        /// For third channel of the DIY-devices led 194
        /// </summary>
        CLD_C3_194 = 1255,

        /// <summary>
        /// For third channel of the DIY-devices led 195
        /// </summary>
        CLD_C3_195 = 1256,

        /// <summary>
        /// For third channel of the DIY-devices led 196
        /// </summary>
        CLD_C3_196 = 1257,

        /// <summary>
        /// For third channel of the DIY-devices led 197
        /// </summary>
        CLD_C3_197 = 1258,

        /// <summary>
        /// For third channel of the DIY-devices led 198
        /// </summary>
        CLD_C3_198 = 1259,

        /// <summary>
        /// For third channel of the DIY-devices led 199
        /// </summary>
        CLD_C3_199 = 1260,

        /// <summary>
        /// For third channel of the DIY-devices led 200
        /// </summary>
        CLD_C3_200 = 1261,

        /// <summary>
        /// For third channel of the DIY-devices led 201
        /// </summary>
        CLD_C3_201 = 1262,

        /// <summary>
        /// For third channel of the DIY-devices led 202
        /// </summary>
        CLD_C3_202 = 1263,

        /// <summary>
        /// For third channel of the DIY-devices led 203
        /// </summary>
        CLD_C3_203 = 1264,

        /// <summary>
        /// For third channel of the DIY-devices led 204
        /// </summary>
        CLD_C3_204 = 1265,

        /// <summary>
        /// For third channel of the DIY-devices led 205
        /// </summary>
        CLD_C3_205 = 1266,

        /// <summary>
        /// For third channel of the DIY-devices led 206
        /// </summary>
        CLD_C3_206 = 1267,

        /// <summary>
        /// For third channel of the DIY-devices led 207
        /// </summary>
        CLD_C3_207 = 1268,

        /// <summary>
        /// For third channel of the DIY-devices led 208
        /// </summary>
        CLD_C3_208 = 1269,

        /// <summary>
        /// For third channel of the DIY-devices led 209
        /// </summary>
        CLD_C3_209 = 1270,

        /// <summary>
        /// For third channel of the DIY-devices led 210
        /// </summary>
        CLD_C3_210 = 1271,

        /// <summary>
        /// For third channel of the DIY-devices led 211
        /// </summary>
        CLD_C3_211 = 1272,

        /// <summary>
        /// For third channel of the DIY-devices led 212
        /// </summary>
        CLD_C3_212 = 1273,

        /// <summary>
        /// For third channel of the DIY-devices led 213
        /// </summary>
        CLD_C3_213 = 1274,

        /// <summary>
        /// For third channel of the DIY-devices led 214
        /// </summary>
        CLD_C3_214 = 1275,

        /// <summary>
        /// For third channel of the DIY-devices led 215
        /// </summary>
        CLD_C3_215 = 1276,

        /// <summary>
        /// For third channel of the DIY-devices led 216
        /// </summary>
        CLD_C3_216 = 1277,

        /// <summary>
        /// For third channel of the DIY-devices led 217
        /// </summary>
        CLD_C3_217 = 1278,

        /// <summary>
        /// For third channel of the DIY-devices led 218
        /// </summary>
        CLD_C3_218 = 1279,

        /// <summary>
        /// For third channel of the DIY-devices led 219
        /// </summary>
        CLD_C3_219 = 1280,

        /// <summary>
        /// For third channel of the DIY-devices led 220
        /// </summary>
        CLD_C3_220 = 1281,

        /// <summary>
        /// For third channel of the DIY-devices led 221
        /// </summary>
        CLD_C3_221 = 1282,

        /// <summary>
        /// For third channel of the DIY-devices led 222
        /// </summary>
        CLD_C3_222 = 1283,

        /// <summary>
        /// For third channel of the DIY-devices led 223
        /// </summary>
        CLD_C3_223 = 1284,

        /// <summary>
        /// For third channel of the DIY-devices led 224
        /// </summary>
        CLD_C3_224 = 1285,

        /// <summary>
        /// For third channel of the DIY-devices led 225
        /// </summary>
        CLD_C3_225 = 1286,

        /// <summary>
        /// For third channel of the DIY-devices led 226
        /// </summary>
        CLD_C3_226 = 1287,

        /// <summary>
        /// For third channel of the DIY-devices led 227
        /// </summary>
        CLD_C3_227 = 1288,

        /// <summary>
        /// For third channel of the DIY-devices led 228
        /// </summary>
        CLD_C3_228 = 1289,

        /// <summary>
        /// For third channel of the DIY-devices led 229
        /// </summary>
        CLD_C3_229 = 1290,

        /// <summary>
        /// For third channel of the DIY-devices led 230
        /// </summary>
        CLD_C3_230 = 1291,

        /// <summary>
        /// For third channel of the DIY-devices led 231
        /// </summary>
        CLD_C3_231 = 1292,

        /// <summary>
        /// For third channel of the DIY-devices led 232
        /// </summary>
        CLD_C3_232 = 1293,

        /// <summary>
        /// For third channel of the DIY-devices led 233
        /// </summary>
        CLD_C3_233 = 1294,

        /// <summary>
        /// For third channel of the DIY-devices led 234
        /// </summary>
        CLD_C3_234 = 1295,

        /// <summary>
        /// For third channel of the DIY-devices led 235
        /// </summary>
        CLD_C3_235 = 1296,

        /// <summary>
        /// For third channel of the DIY-devices led 236
        /// </summary>
        CLD_C3_236 = 1297,

        /// <summary>
        /// For third channel of the DIY-devices led 237
        /// </summary>
        CLD_C3_237 = 1298,

        /// <summary>
        /// For third channel of the DIY-devices led 238
        /// </summary>
        CLD_C3_238 = 1299,

        /// <summary>
        /// For third channel of the DIY-devices led 239
        /// </summary>
        CLD_C3_239 = 1300,

        /// <summary>
        /// For third channel of the DIY-devices led 240
        /// </summary>
        CLD_C3_240 = 1301,

        /// <summary>
        /// For third channel of the DIY-devices led 241
        /// </summary>
        CLD_C3_241 = 1302,

        /// <summary>
        /// For third channel of the DIY-devices led 242
        /// </summary>
        CLD_C3_242 = 1303,

        /// <summary>
        /// For third channel of the DIY-devices led 243
        /// </summary>
        CLD_C3_243 = 1304,

        /// <summary>
        /// For third channel of the DIY-devices led 244
        /// </summary>
        CLD_C3_244 = 1305,

        /// <summary>
        /// For third channel of the DIY-devices led 245
        /// </summary>
        CLD_C3_245 = 1306,

        /// <summary>
        /// For third channel of the DIY-devices led 246
        /// </summary>
        CLD_C3_246 = 1307,

        /// <summary>
        /// For third channel of the DIY-devices led 247
        /// </summary>
        CLD_C3_247 = 1308,

        /// <summary>
        /// For third channel of the DIY-devices led 248
        /// </summary>
        CLD_C3_248 = 1309,

        /// <summary>
        /// For third channel of the DIY-devices led 249
        /// </summary>
        CLD_C3_249 = 1310,

        /// <summary>
        /// For third channel of the DIY-devices led 250
        /// </summary>
        CLD_C3_250 = 1311,

        /// <summary>
        /// For third channel of the DIY-devices led 251
        /// </summary>
        CLD_C3_251 = 1312,

        /// <summary>
        /// For third channel of the DIY-devices led 252
        /// </summary>
        CLD_C3_252 = 1313,

        /// <summary>
        /// For third channel of the DIY-devices led 253
        /// </summary>
        CLD_C3_253 = 1314,

        /// <summary>
        /// For third channel of the DIY-devices led 254
        /// </summary>
        CLD_C3_254 = 1315,

        /// <summary>
        /// For third channel of the DIY-devices led 255
        /// </summary>
        CLD_C3_255 = 1316,

        /// <summary>
        /// For third channel of the DIY-devices led 256
        /// </summary>
        CLD_C3_256 = 1317,

        /// <summary>
        /// For third channel of the DIY-devices led 257
        /// </summary>
        CLD_C3_257 = 1318,

        /// <summary>
        /// For third channel of the DIY-devices led 258
        /// </summary>
        CLD_C3_258 = 1319,

        /// <summary>
        /// For third channel of the DIY-devices led 259
        /// </summary>
        CLD_C3_259 = 1320,

        /// <summary>
        /// For third channel of the DIY-devices led 260
        /// </summary>
        CLD_C3_260 = 1321,

        /// <summary>
        /// For third channel of the DIY-devices led 261
        /// </summary>
        CLD_C3_261 = 1322,

        /// <summary>
        /// For third channel of the DIY-devices led 262
        /// </summary>
        CLD_C3_262 = 1323,

        /// <summary>
        /// For third channel of the DIY-devices led 263
        /// </summary>
        CLD_C3_263 = 1324,

        /// <summary>
        /// For third channel of the DIY-devices led 264
        /// </summary>
        CLD_C3_264 = 1325,

        /// <summary>
        /// For third channel of the DIY-devices led 265
        /// </summary>
        CLD_C3_265 = 1326,

        /// <summary>
        /// For third channel of the DIY-devices led 266
        /// </summary>
        CLD_C3_266 = 1327,

        /// <summary>
        /// For third channel of the DIY-devices led 267
        /// </summary>
        CLD_C3_267 = 1328,

        /// <summary>
        /// For third channel of the DIY-devices led 268
        /// </summary>
        CLD_C3_268 = 1329,

        /// <summary>
        /// For third channel of the DIY-devices led 269
        /// </summary>
        CLD_C3_269 = 1330,

        /// <summary>
        /// For third channel of the DIY-devices led 270
        /// </summary>
        CLD_C3_270 = 1331,

        /// <summary>
        /// For third channel of the DIY-devices led 271
        /// </summary>
        CLD_C3_271 = 1332,

        /// <summary>
        /// For third channel of the DIY-devices led 272
        /// </summary>
        CLD_C3_272 = 1333,

        /// <summary>
        /// For third channel of the DIY-devices led 273
        /// </summary>
        CLD_C3_273 = 1334,

        /// <summary>
        /// For third channel of the DIY-devices led 274
        /// </summary>
        CLD_C3_274 = 1335,

        /// <summary>
        /// For third channel of the DIY-devices led 275
        /// </summary>
        CLD_C3_275 = 1336,

        /// <summary>
        /// For third channel of the DIY-devices led 276
        /// </summary>
        CLD_C3_276 = 1337,

        /// <summary>
        /// For third channel of the DIY-devices led 277
        /// </summary>
        CLD_C3_277 = 1338,

        /// <summary>
        /// For third channel of the DIY-devices led 278
        /// </summary>
        CLD_C3_278 = 1339,

        /// <summary>
        /// For third channel of the DIY-devices led 279
        /// </summary>
        CLD_C3_279 = 1340,

        /// <summary>
        /// For third channel of the DIY-devices led 280
        /// </summary>
        CLD_C3_280 = 1341,

        /// <summary>
        /// For third channel of the DIY-devices led 281
        /// </summary>
        CLD_C3_281 = 1342,

        /// <summary>
        /// For third channel of the DIY-devices led 282
        /// </summary>
        CLD_C3_282 = 1343,

        /// <summary>
        /// For third channel of the DIY-devices led 283
        /// </summary>
        CLD_C3_283 = 1344,

        /// <summary>
        /// For third channel of the DIY-devices led 284
        /// </summary>
        CLD_C3_284 = 1345,

        /// <summary>
        /// For third channel of the DIY-devices led 285
        /// </summary>
        CLD_C3_285 = 1346,

        /// <summary>
        /// For third channel of the DIY-devices led 286
        /// </summary>
        CLD_C3_286 = 1347,

        /// <summary>
        /// For third channel of the DIY-devices led 287
        /// </summary>
        CLD_C3_287 = 1348,

        /// <summary>
        /// For third channel of the DIY-devices led 288
        /// </summary>
        CLD_C3_288 = 1349,

        /// <summary>
        /// For third channel of the DIY-devices led 289
        /// </summary>
        CLD_C3_289 = 1350,

        /// <summary>
        /// For third channel of the DIY-devices led 290
        /// </summary>
        CLD_C3_290 = 1351,

        /// <summary>
        /// For third channel of the DIY-devices led 291
        /// </summary>
        CLD_C3_291 = 1352,

        /// <summary>
        /// For third channel of the DIY-devices led 292
        /// </summary>
        CLD_C3_292 = 1353,

        /// <summary>
        /// For third channel of the DIY-devices led 293
        /// </summary>
        CLD_C3_293 = 1354,

        /// <summary>
        /// For third channel of the DIY-devices led 294
        /// </summary>
        CLD_C3_294 = 1355,

        /// <summary>
        /// For third channel of the DIY-devices led 295
        /// </summary>
        CLD_C3_295 = 1356,

        /// <summary>
        /// For third channel of the DIY-devices led 296
        /// </summary>
        CLD_C3_296 = 1357,

        /// <summary>
        /// For third channel of the DIY-devices led 297
        /// </summary>
        CLD_C3_297 = 1358,

        /// <summary>
        /// For third channel of the DIY-devices led 298
        /// </summary>
        CLD_C3_298 = 1359,

        /// <summary>
        /// For third channel of the DIY-devices led 299
        /// </summary>
        CLD_C3_299 = 1360,

        /// <summary>
        /// For third channel of the DIY-devices led 300
        /// </summary>
        CLD_C3_300 = 1361,

        /// <summary>
        /// For motherboard zone 1 led
        /// </summary>
        CLMB_Zone1 = 1362,

        /// <summary>
        /// For motherboard zone 2 led
        /// </summary>
        CLMB_Zone2 = 1363,

        /// <summary>
        /// For motherboard zone 3 led
        /// </summary>
        CLMB_Zone3 = 1364,

        /// <summary>
        /// For motherboard zone 4 led
        /// </summary>
        CLMB_Zone4 = 1365,

        /// <summary>
        /// For motherboard zone 5 led
        /// </summary>
        CLMB_Zone5 = 1366,

        /// <summary>
        /// For motherboard zone 6 led
        /// </summary>
        CLMB_Zone6 = 1367,

        /// <summary>
        /// For motherboard zone 7 led
        /// </summary>
        CLMB_Zone7 = 1368,

        /// <summary>
        /// For motherboard zone 8 led
        /// </summary>
        CLMB_Zone8 = 1369,

        /// <summary>
        /// For motherboard zone 9 led
        /// </summary>
        CLMB_Zone9 = 1370,

        /// <summary>
        /// For motherboard zone 10 led
        /// </summary>
        CLMB_Zone10 = 1371,

        /// <summary>
        /// For motherboard zone 11 led
        /// </summary>
        CLMB_Zone11 = 1372,

        /// <summary>
        /// For motherboard zone 12 led
        /// </summary>
        CLMB_Zone12 = 1373,

        /// <summary>
        /// For motherboard zone 13 led
        /// </summary>
        CLMB_Zone13 = 1374,

        /// <summary>
        /// For motherboard zone 14 led
        /// </summary>
        CLMB_Zone14 = 1375,

        /// <summary>
        /// For motherboard zone 15 led
        /// </summary>
        CLMB_Zone15 = 1376,

        /// <summary>
        /// For motherboard zone 16 led
        /// </summary>
        CLMB_Zone16 = 1377,

        /// <summary>
        /// For motherboard zone 17 led
        /// </summary>
        CLMB_Zone17 = 1378,

        /// <summary>
        /// For motherboard zone 18 led
        /// </summary>
        CLMB_Zone18 = 1379,

        /// <summary>
        /// For motherboard zone 19 led
        /// </summary>
        CLMB_Zone19 = 1380,

        /// <summary>
        /// For motherboard zone 20 led
        /// </summary>
        CLMB_Zone20 = 1381,

        /// <summary>
        /// For motherboard zone 21 led
        /// </summary>
        CLMB_Zone21 = 1382,

        /// <summary>
        /// For motherboard zone 22 led
        /// </summary>
        CLMB_Zone22 = 1383,

        /// <summary>
        /// For motherboard zone 23 led
        /// </summary>
        CLMB_Zone23 = 1384,

        /// <summary>
        /// For motherboard zone 24 led
        /// </summary>
        CLMB_Zone24 = 1385,

        /// <summary>
        /// For motherboard zone 25 led
        /// </summary>
        CLMB_Zone25 = 1386,

        /// <summary>
        /// For motherboard zone 26 led
        /// </summary>
        CLMB_Zone26 = 1387,

        /// <summary>
        /// For motherboard zone 27 led
        /// </summary>
        CLMB_Zone27 = 1388,

        /// <summary>
        /// For motherboard zone 28 led
        /// </summary>
        CLMB_Zone28 = 1389,

        /// <summary>
        /// For motherboard zone 29 led
        /// </summary>
        CLMB_Zone29 = 1390,

        /// <summary>
        /// For motherboard zone 30 led
        /// </summary>
        CLMB_Zone30 = 1391,

        /// <summary>
        /// For motherboard zone 31 led
        /// </summary>
        CLMB_Zone31 = 1392,

        /// <summary>
        /// For motherboard zone 32 led
        /// </summary>
        CLMB_Zone32 = 1393,

        /// <summary>
        /// For motherboard zone 33 led
        /// </summary>
        CLMB_Zone33 = 1394,

        /// <summary>
        /// For motherboard zone 34 led
        /// </summary>
        CLMB_Zone34 = 1395,

        /// <summary>
        /// For motherboard zone 35 led
        /// </summary>
        CLMB_Zone35 = 1396,

        /// <summary>
        /// For motherboard zone 36 led
        /// </summary>
        CLMB_Zone36 = 1397,

        /// <summary>
        /// For motherboard zone 37 led
        /// </summary>
        CLMB_Zone37 = 1398,

        /// <summary>
        /// For motherboard zone 38 led
        /// </summary>
        CLMB_Zone38 = 1399,

        /// <summary>
        /// For motherboard zone 39 led
        /// </summary>
        CLMB_Zone39 = 1400,

        /// <summary>
        /// For motherboard zone 40 led
        /// </summary>
        CLMB_Zone40 = 1401,

        /// <summary>
        /// For motherboard zone 41 led
        /// </summary>
        CLMB_Zone41 = 1402,

        /// <summary>
        /// For motherboard zone 42 led
        /// </summary>
        CLMB_Zone42 = 1403,

        /// <summary>
        /// For motherboard zone 43 led
        /// </summary>
        CLMB_Zone43 = 1404,

        /// <summary>
        /// For motherboard zone 44 led
        /// </summary>
        CLMB_Zone44 = 1405,

        /// <summary>
        /// For motherboard zone 45 led
        /// </summary>
        CLMB_Zone45 = 1406,

        /// <summary>
        /// For motherboard zone 46 led
        /// </summary>
        CLMB_Zone46 = 1407,

        /// <summary>
        /// For motherboard zone 47 led
        /// </summary>
        CLMB_Zone47 = 1408,

        /// <summary>
        /// For motherboard zone 48 led
        /// </summary>
        CLMB_Zone48 = 1409,

        /// <summary>
        /// For motherboard zone 49 led
        /// </summary>
        CLMB_Zone49 = 1410,

        /// <summary>
        /// For motherboard zone 50 led
        /// </summary>
        CLMB_Zone50 = 1411,

        /// <summary>
        /// For motherboard zone 51 led
        /// </summary>
        CLMB_Zone51 = 1412,

        /// <summary>
        /// For motherboard zone 52 led
        /// </summary>
        CLMB_Zone52 = 1413,

        /// <summary>
        /// For motherboard zone 53 led
        /// </summary>
        CLMB_Zone53 = 1414,

        /// <summary>
        /// For motherboard zone 54 led
        /// </summary>
        CLMB_Zone54 = 1415,

        /// <summary>
        /// For motherboard zone 55 led
        /// </summary>
        CLMB_Zone55 = 1416,

        /// <summary>
        /// For motherboard zone 56 led
        /// </summary>
        CLMB_Zone56 = 1417,

        /// <summary>
        /// For motherboard zone 57 led
        /// </summary>
        CLMB_Zone57 = 1418,

        /// <summary>
        /// For motherboard zone 58 led
        /// </summary>
        CLMB_Zone58 = 1419,

        /// <summary>
        /// For motherboard zone 59 led
        /// </summary>
        CLMB_Zone59 = 1420,

        /// <summary>
        /// For motherboard zone 60 led
        /// </summary>
        CLMB_Zone60 = 1421,

        /// <summary>
        /// For motherboard zone 61 led
        /// </summary>
        CLMB_Zone61 = 1422,

        /// <summary>
        /// For motherboard zone 62 led
        /// </summary>
        CLMB_Zone62 = 1423,

        /// <summary>
        /// For motherboard zone 63 led
        /// </summary>
        CLMB_Zone63 = 1424,

        /// <summary>
        /// For motherboard zone 64 led
        /// </summary>
        CLMB_Zone64 = 1425,

        /// <summary>
        /// For motherboard zone 65 led
        /// </summary>
        CLMB_Zone65 = 1426,

        /// <summary>
        /// For motherboard zone 66 led
        /// </summary>
        CLMB_Zone66 = 1427,

        /// <summary>
        /// For motherboard zone 67 led
        /// </summary>
        CLMB_Zone67 = 1428,

        /// <summary>
        /// For motherboard zone 68 led
        /// </summary>
        CLMB_Zone68 = 1429,

        /// <summary>
        /// For motherboard zone 69 led
        /// </summary>
        CLMB_Zone69 = 1430,

        /// <summary>
        /// For motherboard zone 70 led
        /// </summary>
        CLMB_Zone70 = 1431,

        /// <summary>
        /// For motherboard zone 71 led
        /// </summary>
        CLMB_Zone71 = 1432,

        /// <summary>
        /// For motherboard zone 72 led
        /// </summary>
        CLMB_Zone72 = 1433,

        /// <summary>
        /// For motherboard zone 73 led
        /// </summary>
        CLMB_Zone73 = 1434,

        /// <summary>
        /// For motherboard zone 74 led
        /// </summary>
        CLMB_Zone74 = 1435,

        /// <summary>
        /// For motherboard zone 75 led
        /// </summary>
        CLMB_Zone75 = 1436,

        /// <summary>
        /// For motherboard zone 76 led
        /// </summary>
        CLMB_Zone76 = 1437,

        /// <summary>
        /// For motherboard zone 77 led
        /// </summary>
        CLMB_Zone77 = 1438,

        /// <summary>
        /// For motherboard zone 78 led
        /// </summary>
        CLMB_Zone78 = 1439,

        /// <summary>
        /// For motherboard zone 79 led
        /// </summary>
        CLMB_Zone79 = 1440,

        /// <summary>
        /// For motherboard zone 80 led
        /// </summary>
        CLMB_Zone80 = 1441,

        /// <summary>
        /// For motherboard zone 81 led
        /// </summary>
        CLMB_Zone81 = 1442,

        /// <summary>
        /// For motherboard zone 82 led
        /// </summary>
        CLMB_Zone82 = 1443,

        /// <summary>
        /// For motherboard zone 83 led
        /// </summary>
        CLMB_Zone83 = 1444,

        /// <summary>
        /// For motherboard zone 84 led
        /// </summary>
        CLMB_Zone84 = 1445,

        /// <summary>
        /// For motherboard zone 85 led
        /// </summary>
        CLMB_Zone85 = 1446,

        /// <summary>
        /// For motherboard zone 86 led
        /// </summary>
        CLMB_Zone86 = 1447,

        /// <summary>
        /// For motherboard zone 87 led
        /// </summary>
        CLMB_Zone87 = 1448,

        /// <summary>
        /// For motherboard zone 88 led
        /// </summary>
        CLMB_Zone88 = 1449,

        /// <summary>
        /// For motherboard zone 89 led
        /// </summary>
        CLMB_Zone89 = 1450,

        /// <summary>
        /// For motherboard zone 90 led
        /// </summary>
        CLMB_Zone90 = 1451,

        /// <summary>
        /// For motherboard zone 91 led
        /// </summary>
        CLMB_Zone91 = 1452,

        /// <summary>
        /// For motherboard zone 92 led
        /// </summary>
        CLMB_Zone92 = 1453,

        /// <summary>
        /// For motherboard zone 93 led
        /// </summary>
        CLMB_Zone93 = 1454,

        /// <summary>
        /// For motherboard zone 94 led
        /// </summary>
        CLMB_Zone94 = 1455,

        /// <summary>
        /// For motherboard zone 95 led
        /// </summary>
        CLMB_Zone95 = 1456,

        /// <summary>
        /// For motherboard zone 96 led
        /// </summary>
        CLMB_Zone96 = 1457,

        /// <summary>
        /// For motherboard zone 97 led
        /// </summary>
        CLMB_Zone97 = 1458,

        /// <summary>
        /// For motherboard zone 98 led
        /// </summary>
        CLMB_Zone98 = 1459,

        /// <summary>
        /// For motherboard zone 99 led
        /// </summary>
        CLMB_Zone99 = 1460,

        /// <summary>
        /// For motherboard zone 100 led
        /// </summary>
        CLMB_Zone100 = 1461,

        /// <summary>
        /// For graphics card zone 1 led
        /// </summary>
        CLGPU_Zone1 = 1462,

        /// <summary>
        /// For graphics card zone 2 led
        /// </summary>
        CLGPU_Zone2 = 1463,

        /// <summary>
        /// For graphics card zone 3 led
        /// </summary>
        CLGPU_Zone3 = 1464,

        /// <summary>
        /// For graphics card zone 4 led
        /// </summary>
        CLGPU_Zone4 = 1465,

        /// <summary>
        /// For graphics card zone 5 led
        /// </summary>
        CLGPU_Zone5 = 1466,

        /// <summary>
        /// For graphics card zone 6 led
        /// </summary>
        CLGPU_Zone6 = 1467,

        /// <summary>
        /// For graphics card zone 7 led
        /// </summary>
        CLGPU_Zone7 = 1468,

        /// <summary>
        /// For graphics card zone 8 led
        /// </summary>
        CLGPU_Zone8 = 1469,

        /// <summary>
        /// For graphics card zone 9 led
        /// </summary>
        CLGPU_Zone9 = 1470,

        /// <summary>
        /// For graphics card zone 10 led
        /// </summary>
        CLGPU_Zone10 = 1471,

        /// <summary>
        /// For graphics card zone 11 led
        /// </summary>
        CLGPU_Zone11 = 1472,

        /// <summary>
        /// For graphics card zone 12 led
        /// </summary>
        CLGPU_Zone12 = 1473,

        /// <summary>
        /// For graphics card zone 13 led
        /// </summary>
        CLGPU_Zone13 = 1474,

        /// <summary>
        /// For graphics card zone 14 led
        /// </summary>
        CLGPU_Zone14 = 1475,

        /// <summary>
        /// For graphics card zone 15 led
        /// </summary>
        CLGPU_Zone15 = 1476,

        /// <summary>
        /// For graphics card zone 16 led
        /// </summary>
        CLGPU_Zone16 = 1477,

        /// <summary>
        /// For graphics card zone 17 led
        /// </summary>
        CLGPU_Zone17 = 1478,

        /// <summary>
        /// For graphics card zone 18 led
        /// </summary>
        CLGPU_Zone18 = 1479,

        /// <summary>
        /// For graphics card zone 19 led
        /// </summary>
        CLGPU_Zone19 = 1480,

        /// <summary>
        /// For graphics card zone 20 led
        /// </summary>
        CLGPU_Zone20 = 1481,

        /// <summary>
        /// For graphics card zone 21 led
        /// </summary>
        CLGPU_Zone21 = 1482,

        /// <summary>
        /// For graphics card zone 22 led
        /// </summary>
        CLGPU_Zone22 = 1483,

        /// <summary>
        /// For graphics card zone 23 led
        /// </summary>
        CLGPU_Zone23 = 1484,

        /// <summary>
        /// For graphics card zone 24 led
        /// </summary>
        CLGPU_Zone24 = 1485,

        /// <summary>
        /// For graphics card zone 25 led
        /// </summary>
        CLGPU_Zone25 = 1486,

        /// <summary>
        /// For graphics card zone 26 led
        /// </summary>
        CLGPU_Zone26 = 1487,

        /// <summary>
        /// For graphics card zone 27 led
        /// </summary>
        CLGPU_Zone27 = 1488,

        /// <summary>
        /// For graphics card zone 28 led
        /// </summary>
        CLGPU_Zone28 = 1489,

        /// <summary>
        /// For graphics card zone 29 led
        /// </summary>
        CLGPU_Zone29 = 1490,

        /// <summary>
        /// For graphics card zone 30 led
        /// </summary>
        CLGPU_Zone30 = 1491,

        /// <summary>
        /// For graphics card zone 31 led
        /// </summary>
        CLGPU_Zone31 = 1492,

        /// <summary>
        /// For graphics card zone 32 led
        /// </summary>
        CLGPU_Zone32 = 1493,

        /// <summary>
        /// For graphics card zone 33 led
        /// </summary>
        CLGPU_Zone33 = 1494,

        /// <summary>
        /// For graphics card zone 34 led
        /// </summary>
        CLGPU_Zone34 = 1495,

        /// <summary>
        /// For graphics card zone 35 led
        /// </summary>
        CLGPU_Zone35 = 1496,

        /// <summary>
        /// For graphics card zone 36 led
        /// </summary>
        CLGPU_Zone36 = 1497,

        /// <summary>
        /// For graphics card zone 37 led
        /// </summary>
        CLGPU_Zone37 = 1498,

        /// <summary>
        /// For graphics card zone 38 led
        /// </summary>
        CLGPU_Zone38 = 1499,

        /// <summary>
        /// For graphics card zone 39 led
        /// </summary>
        CLGPU_Zone39 = 1500,

        /// <summary>
        /// For graphics card zone 40 led
        /// </summary>
        CLGPU_Zone40 = 1501,

        /// <summary>
        /// For graphics card zone 41 led
        /// </summary>
        CLGPU_Zone41 = 1502,

        /// <summary>
        /// For graphics card zone 42 led
        /// </summary>
        CLGPU_Zone42 = 1503,

        /// <summary>
        /// For graphics card zone 43 led
        /// </summary>
        CLGPU_Zone43 = 1504,

        /// <summary>
        /// For graphics card zone 44 led
        /// </summary>
        CLGPU_Zone44 = 1505,

        /// <summary>
        /// For graphics card zone 45 led
        /// </summary>
        CLGPU_Zone45 = 1506,

        /// <summary>
        /// For graphics card zone 46 led
        /// </summary>
        CLGPU_Zone46 = 1507,

        /// <summary>
        /// For graphics card zone 47 led
        /// </summary>
        CLGPU_Zone47 = 1508,

        /// <summary>
        /// For graphics card zone 48 led
        /// </summary>
        CLGPU_Zone48 = 1509,

        /// <summary>
        /// For graphics card zone 49 led
        /// </summary>
        CLGPU_Zone49 = 1510,

        /// <summary>
        /// For graphics card zone 50 led
        /// </summary>
        CLGPU_Zone50 = 1511,

        /// <summary>
        /// For keyboard light pipe zone 20 led
        /// </summary>
        CLKLP_Zone20 = 1512,

        /// <summary>
        /// For keyboard light pipe zone 21 led
        /// </summary>
        CLKLP_Zone21 = 1513,

        /// <summary>
        /// For keyboard light pipe zone 22 led
        /// </summary>
        CLKLP_Zone22 = 1514,

        /// <summary>
        /// For keyboard light pipe zone 23 led
        /// </summary>
        CLKLP_Zone23 = 1515,

        /// <summary>
        /// For keyboard light pipe zone 24 led
        /// </summary>
        CLKLP_Zone24 = 1516,

        /// <summary>
        /// For keyboard light pipe zone 25 led
        /// </summary>
        CLKLP_Zone25 = 1517,

        /// <summary>
        /// For keyboard light pipe zone 26 led
        /// </summary>
        CLKLP_Zone26 = 1518,

        /// <summary>
        /// For keyboard light pipe zone 27 led
        /// </summary>
        CLKLP_Zone27 = 1519,

        /// <summary>
        /// For keyboard light pipe zone 28 led
        /// </summary>
        CLKLP_Zone28 = 1520,

        /// <summary>
        /// For keyboard light pipe zone 29 led
        /// </summary>
        CLKLP_Zone29 = 1521,

        /// <summary>
        /// For keyboard light pipe zone 30 led
        /// </summary>
        CLKLP_Zone30 = 1522,

        /// <summary>
        /// For keyboard light pipe zone 31 led
        /// </summary>
        CLKLP_Zone31 = 1523,

        /// <summary>
        /// For keyboard light pipe zone 32 led
        /// </summary>
        CLKLP_Zone32 = 1524,

        /// <summary>
        /// For keyboard light pipe zone 33 led
        /// </summary>
        CLKLP_Zone33 = 1525,

        /// <summary>
        /// For keyboard light pipe zone 34 led
        /// </summary>
        CLKLP_Zone34 = 1526,

        /// <summary>
        /// For keyboard light pipe zone 35 led
        /// </summary>
        CLKLP_Zone35 = 1527,

        /// <summary>
        /// For keyboard light pipe zone 36 led
        /// </summary>
        CLKLP_Zone36 = 1528,

        /// <summary>
        /// For keyboard light pipe zone 37 led
        /// </summary>
        CLKLP_Zone37 = 1529,

        /// <summary>
        /// For keyboard light pipe zone 38 led
        /// </summary>
        CLKLP_Zone38 = 1530,

        /// <summary>
        /// For keyboard light pipe zone 39 led
        /// </summary>
        CLKLP_Zone39 = 1531,

        /// <summary>
        /// For keyboard light pipe zone 40 led
        /// </summary>
        CLKLP_Zone40 = 1532,

        /// <summary>
        /// For keyboard light pipe zone 41 led
        /// </summary>
        CLKLP_Zone41 = 1533,

        /// <summary>
        /// For keyboard light pipe zone 42 led
        /// </summary>
        CLKLP_Zone42 = 1534,

        /// <summary>
        /// For keyboard light pipe zone 43 led
        /// </summary>
        CLKLP_Zone43 = 1535,

        /// <summary>
        /// For keyboard light pipe zone 44 led
        /// </summary>
        CLKLP_Zone44 = 1536,

        /// <summary>
        /// For keyboard light pipe zone 45 led
        /// </summary>
        CLKLP_Zone45 = 1537,

        /// <summary>
        /// For keyboard light pipe zone 46 led
        /// </summary>
        CLKLP_Zone46 = 1538,

        /// <summary>
        /// For keyboard light pipe zone 47 led
        /// </summary>
        CLKLP_Zone47 = 1539,

        /// <summary>
        /// For keyboard light pipe zone 48 led
        /// </summary>
        CLKLP_Zone48 = 1540,

        /// <summary>
        /// For keyboard light pipe zone 49 led
        /// </summary>
        CLKLP_Zone49 = 1541,

        /// <summary>
        /// For keyboard light pipe zone 50 led
        /// </summary>
        CLKLP_Zone50 = 1542,

        /// <summary>
        /// For keyboard profile led
        /// </summary>
        CLK_Profile = 1543,

        /// <summary>
        /// The last available led
        /// </summary>
        CLI_Last = CLK_Profile
    }
}
