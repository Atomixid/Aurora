﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DK = Aurora.Devices.DeviceKeys;

namespace Aurora.Devices.OpenRGB
{
    public static class OpenRGBKeyNames
    {
        public static readonly Dictionary<string, DK> KeyNames = new Dictionary<string, DK>()
        {
            { "Key: A"                , DK.A                      },
            { "Key: B"                , DK.B                      },
            { "Key: C"                , DK.C                      },
            { "Key: D"                , DK.D                      },
            { "Key: E"                , DK.E                      },
            { "Key: F"                , DK.F                      },
            { "Key: G"                , DK.G                      },
            { "Key: H"                , DK.H                      },
            { "Key: I"                , DK.I                      },
            { "Key: J"                , DK.J                      },
            { "Key: K"                , DK.K                      },
            { "Key: L"                , DK.L                      },
            { "Key: M"                , DK.M                      },
            { "Key: N"                , DK.N                      },
            { "Key: O"                , DK.O                      },
            { "Key: P"                , DK.P                      },
            { "Key: Q"                , DK.Q                      },
            { "Key: R"                , DK.R                      },
            { "Key: S"                , DK.S                      },
            { "Key: T"                , DK.T                      },
            { "Key: U"                , DK.U                      },
            { "Key: V"                , DK.V                      },
            { "Key: W"                , DK.W                      },
            { "Key: X"                , DK.X                      },
            { "Key: Y"                , DK.Y                      },
            { "Key: Z"                , DK.Z                      },
            { "Key: 1"                , DK.ONE                    },
            { "Key: 2"                , DK.TWO                    },
            { "Key: 3"                , DK.THREE                  },
            { "Key: 4"                , DK.FOUR                   },
            { "Key: 5"                , DK.FIVE                   },
            { "Key: 6"                , DK.SIX                    },
            { "Key: 7"                , DK.SEVEN                  },
            { "Key: 8"                , DK.EIGHT                  },
            { "Key: 9"                , DK.NINE                   },
            { "Key: 0"                , DK.ZERO                   },
            { "Key: Enter"            , DK.ENTER                  },//TODO: Fix
            { "Key: Enter (ISO)"      , DK.ENTER                  },
            { "Key: Escape"           , DK.ESC                    },
            { "Key: Backspace"        , DK.BACKSPACE              },
            { "Key: Tab"              , DK.TAB                    },
            { "Key: Space"            , DK.SPACE                  },
            { "Key: -"                , DK.MINUS                  },
            { "Key: ="                , DK.EQUALS                 },
            { "Key: ["                , DK.OPEN_BRACKET           },
            { "Key: ]"                , DK.CLOSE_BRACKET          },
            { "Key: \\ (ANSI)"        , DK.BACKSLASH              },
            { "Key: #"                , DK.HASHTAG                },
            { "Key: ;"                , DK.SEMICOLON              },
            { "Key: '"                , DK.APOSTROPHE             },
            { "Key: `"                , DK.TILDE                  },
            { "Key: ,"                , DK.COMMA                  },
            { "Key: ."                , DK.PERIOD                 },
            { "Key: /"                , DK.FORWARD_SLASH          },
            { "Key: / (ABNT)"         , DK.FORWARD_SLASH          },
            { "Key: Caps Lock"        , DK.CAPS_LOCK              },
            { "Key: F1"               , DK.F1                     },
            { "Key: F2"               , DK.F2                     },
            { "Key: F3"               , DK.F3                     },
            { "Key: F4"               , DK.F4                     },
            { "Key: F5"               , DK.F5                     },
            { "Key: F6"               , DK.F6                     },
            { "Key: F7"               , DK.F7                     },
            { "Key: F8"               , DK.F8                     },
            { "Key: F9"               , DK.F9                     },
            { "Key: F10"              , DK.F10                    },
            { "Key: F11"              , DK.F11                    },
            { "Key: F12"              , DK.F12                    },
            { "Key: Print Screen"     , DK.PRINT_SCREEN           },
            { "Key: Scroll Lock"      , DK.SCROLL_LOCK            },
            { "Key: Pause/Break"      , DK.PAUSE_BREAK            },
            { "Key: Insert"           , DK.INSERT                 },
            { "Key: Home"             , DK.HOME                   },
            { "Key: Page Up"          , DK.PAGE_UP                },
            { "Key: Delete"           , DK.DELETE                 },
            { "Key: End"              , DK.END                    },
            { "Key: Page Down"        , DK.PAGE_DOWN              },
            { "Key: Right Arrow"      , DK.ARROW_RIGHT            },
            { "Key: Left Arrow"       , DK.ARROW_LEFT             },
            { "Key: Down Arrow"       , DK.ARROW_DOWN             },
            { "Key: Up Arrow"         , DK.ARROW_UP               },
            { "Key: Num Lock"         , DK.NUM_LOCK               },
            { "Key: Number Pad /"     , DK.NUM_SLASH              },
            { "Key: Number Pad *"     , DK.NUM_ASTERISK           },
            { "Key: Number Pad -"     , DK.NUM_MINUS              },
            { "Key: Number Pad +"     , DK.NUM_PLUS               },
            { "Key: Number Pad Enter" , DK.NUM_ENTER              },
            { "Key: Number Pad 1"     , DK.NUM_ONE                },
            { "Key: Number Pad 2"     , DK.NUM_TWO                },
            { "Key: Number Pad 3"     , DK.NUM_THREE              },
            { "Key: Number Pad 4"     , DK.NUM_FOUR               },
            { "Key: Number Pad 5"     , DK.NUM_FIVE               },
            { "Key: Number Pad 6"     , DK.NUM_SIX                },
            { "Key: Number Pad 7"     , DK.NUM_SEVEN              },
            { "Key: Number Pad 8"     , DK.NUM_EIGHT              },
            { "Key: Number Pad 9"     , DK.NUM_NINE               },
            { "Key: Number Pad 0"     , DK.NUM_ZERO               },
            { "Key: Number Pad ."     , DK.NUM_PERIOD             },
            { "Key: Left Fn"          , DK.LEFT_FN                },
            { "Key: Right Fn"         , DK.FN_Key                 },
            { "Key: \\ (ISO)"         , DK.BACKSLASH_UK           },
            { "Key: Menu"             , DK.APPLICATION_SELECT     },
            { "Key: Left Control"     , DK.LEFT_CONTROL           },
            { "Key: Left Shift"       , DK.LEFT_SHIFT             },
            { "Key: Left Alt"         , DK.LEFT_ALT               },
            { "Key: Left Windows"     , DK.LEFT_WINDOWS           },
            { "Key: Right Control"    , DK.RIGHT_CONTROL          },
            { "Key: Right Shift"      , DK.RIGHT_SHIFT            },
            { "Key: Right Alt"        , DK.RIGHT_ALT              },
            { "Key: Right Windows"    , DK.RIGHT_WINDOWS          },
            { "Key: Media Next"       , DK.MEDIA_NEXT             },
            { "Key: Media Previous"   , DK.MEDIA_PREVIOUS         },
            { "Key: Media Stop"       , DK.MEDIA_STOP             },
            { "Key: Media Pause"      , DK.MEDIA_PAUSE            },
            { "Key: Media Play"       , DK.MEDIA_PLAY             },
            { "Key: Media Play/Pause" , DK.MEDIA_PLAY_PAUSE       },
            { "Key: Media Mute"       , DK.VOLUME_MUTE            },
            { "Key: Media Volume Down", DK.VOLUME_DOWN            },
            { "Key: Media Volume Up"  , DK.VOLUME_UP              },
            { "Logo"                  , DK.LOGO                   },
            { "Key: Brightness"       , DK.BRIGHTNESS_SWITCH      },
            { "Key: M1"               , DK.G1                     },
            { "Key: M2"               , DK.G2                     },
            { "Key: M3"               , DK.G3                     },
            { "Key: M4"               , DK.G4                     },
            { "Key: M5"               , DK.G5                     },
            { "Key: G0"               , DK.G0                     },
            { "Key: G1"               , DK.G1                     },
            { "Key: G2"               , DK.G2                     },
            { "Key: G3"               , DK.G3                     },
            { "Key: G4"               , DK.G4                     },
            { "Key: G5"               , DK.G5                     },
            //{ "Logo"                  , DK.Peripheral_Logo        },
            { "Mouse"                 , DK.Peripheral_Logo        },
            { "Scroll Wheel"          , DK.Peripheral_ScrollWheel },
            { "DPI"                   , DK.Peripheral_ScrollWheel },
            { "Front"                 , DK.Peripheral_FrontLight  },
            { "RGB Strip 1"           , DK.ADDITIONALLIGHT1       },
            { "RGB Strip 2"           , DK.ADDITIONALLIGHT2       },
            { "RGB Strip 3"           , DK.ADDITIONALLIGHT3       },
            { "RGB Strip 4"           , DK.ADDITIONALLIGHT4       },
            { "RGB Strip 5"           , DK.ADDITIONALLIGHT5       },
            { "RGB Strip 6"           , DK.ADDITIONALLIGHT6       },
            { "RGB Strip 7"           , DK.ADDITIONALLIGHT7       },
            { "RGB Strip 8"           , DK.ADDITIONALLIGHT8       },
            { "RGB Strip 9"           , DK.ADDITIONALLIGHT9       },
            { "RGB Strip 10"           , DK.ADDITIONALLIGHT10      },
            { "RGB Strip 11"           , DK.ADDITIONALLIGHT11      },
            { "RGB Strip 12"           , DK.ADDITIONALLIGHT12      },
            { "RGB Strip 13"           , DK.ADDITIONALLIGHT13      },
            { "RGB Strip 14"           , DK.ADDITIONALLIGHT14      },
            { "RGB Strip 15"           , DK.ADDITIONALLIGHT15      },
            { "RGB Strip 16"           , DK.ADDITIONALLIGHT16      },
            { "RGB Strip 17"           , DK.ADDITIONALLIGHT17      },
            { "RGB Strip 18"           , DK.ADDITIONALLIGHT18      },
            { "RGB Strip 19"           , DK.ADDITIONALLIGHT19      },
            { "RGB Strip 20"           , DK.ADDITIONALLIGHT20      },
            { "RGB Strip 21"           , DK.ADDITIONALLIGHT21      },
            { "RGB Strip 22"           , DK.ADDITIONALLIGHT22      },
            { "RGB Strip 23"           , DK.ADDITIONALLIGHT23      },
            { "RGB Strip 24"           , DK.ADDITIONALLIGHT24      },
            { "RGB Strip 25"           , DK.ADDITIONALLIGHT25      },
            { "RGB Strip 26"           , DK.ADDITIONALLIGHT26      },
            { "RGB Strip 27"           , DK.ADDITIONALLIGHT27      },
            { "RGB Strip 28"           , DK.ADDITIONALLIGHT28      },
            { "RGB Strip 29"           , DK.ADDITIONALLIGHT29      },
            { "RGB Strip 30"           , DK.ADDITIONALLIGHT30      },
            { "RGB Strip 31"           , DK.ADDITIONALLIGHT31      },
            { "RGB Strip 32"           , DK.ADDITIONALLIGHT32      },
            { "RGB Strip 33"           , DK.ADDITIONALLIGHT33      },
            { "RGB Strip 34"           , DK.ADDITIONALLIGHT34      },
            { "RGB Strip 35"           , DK.ADDITIONALLIGHT35      },
            { "RGB Strip 36"           , DK.ADDITIONALLIGHT36      },
            { "RGB Strip 37"           , DK.ADDITIONALLIGHT37      },
            { "RGB Strip 38"           , DK.ADDITIONALLIGHT38      },
            { "RGB Strip 39"           , DK.ADDITIONALLIGHT39      },
            { "RGB Strip 40"           , DK.ADDITIONALLIGHT40      },
            { "RGB Strip 41"           , DK.ADDITIONALLIGHT41      },
            { "RGB Strip 42"           , DK.ADDITIONALLIGHT42      },
            { "RGB Strip 43"           , DK.ADDITIONALLIGHT43      },
            { "RGB Strip 44"           , DK.ADDITIONALLIGHT44      },
            { "RGB Strip 45"           , DK.ADDITIONALLIGHT45      },
            { "RGB Strip 46"           , DK.ADDITIONALLIGHT46      },
            { "RGB Strip 47"           , DK.ADDITIONALLIGHT47      },
            { "RGB Strip 48"           , DK.ADDITIONALLIGHT48      },
            { "RGB Strip 49"           , DK.ADDITIONALLIGHT49      },
            { "RGB Strip 50"           , DK.ADDITIONALLIGHT50      },
            { "RGB Strip 51"           , DK.ADDITIONALLIGHT51      },
            { "RGB Strip 52"           , DK.ADDITIONALLIGHT52      },
            { "RGB Strip 53"           , DK.ADDITIONALLIGHT53      },
            { "RGB Strip 54"           , DK.ADDITIONALLIGHT54      },
            { "RGB Strip 55"           , DK.ADDITIONALLIGHT55      },
            { "RGB Strip 56"           , DK.ADDITIONALLIGHT56      },
            { "RGB Strip 57"           , DK.ADDITIONALLIGHT57      },
            { "RGB Strip 58"           , DK.ADDITIONALLIGHT58      },
            { "RGB Strip 59"           , DK.ADDITIONALLIGHT59      },
            { "RGB Strip 60"           , DK.ADDITIONALLIGHT60      },
            { "Key: Calculator"        , DK.CALC                   },
        };

        public static readonly DK[] MousepadLights = new[]
        {
            DK.MOUSEPADLIGHT1,
            DK.MOUSEPADLIGHT2,
            DK.MOUSEPADLIGHT3,
            DK.MOUSEPADLIGHT4,
            DK.MOUSEPADLIGHT5,
            DK.MOUSEPADLIGHT6,
            DK.MOUSEPADLIGHT7,
            DK.MOUSEPADLIGHT8,
            DK.MOUSEPADLIGHT9,
            DK.MOUSEPADLIGHT10,
            DK.MOUSEPADLIGHT11,
            DK.MOUSEPADLIGHT12,
            DK.MOUSEPADLIGHT13,
            DK.MOUSEPADLIGHT14,
            DK.MOUSEPADLIGHT15,
        };

        public static readonly DK[] AdditionalLights = new[]
        {
            DK.ADDITIONALLIGHT1,
            DK.ADDITIONALLIGHT2,
            DK.ADDITIONALLIGHT3,
            DK.ADDITIONALLIGHT4,
            DK.ADDITIONALLIGHT5,
            DK.ADDITIONALLIGHT6,
            DK.ADDITIONALLIGHT7,
            DK.ADDITIONALLIGHT8,
            DK.ADDITIONALLIGHT9,
            DK.ADDITIONALLIGHT10,
            DK.ADDITIONALLIGHT11,
            DK.ADDITIONALLIGHT12,
            DK.ADDITIONALLIGHT13,
            DK.ADDITIONALLIGHT14,
            DK.ADDITIONALLIGHT15,
            DK.ADDITIONALLIGHT16,
            DK.ADDITIONALLIGHT17,
            DK.ADDITIONALLIGHT18,
            DK.ADDITIONALLIGHT19,
            DK.ADDITIONALLIGHT20,
            DK.ADDITIONALLIGHT21,
            DK.ADDITIONALLIGHT22,
            DK.ADDITIONALLIGHT23,
            DK.ADDITIONALLIGHT24,
            DK.ADDITIONALLIGHT25,
            DK.ADDITIONALLIGHT26,
            DK.ADDITIONALLIGHT27,
            DK.ADDITIONALLIGHT28,
            DK.ADDITIONALLIGHT29,
            DK.ADDITIONALLIGHT30,
            DK.ADDITIONALLIGHT31,
            DK.ADDITIONALLIGHT32,
            DK.ADDITIONALLIGHT33,
            DK.ADDITIONALLIGHT34,
            DK.ADDITIONALLIGHT35,
            DK.ADDITIONALLIGHT36,
            DK.ADDITIONALLIGHT37,
            DK.ADDITIONALLIGHT38,
            DK.ADDITIONALLIGHT39,
            DK.ADDITIONALLIGHT40,
            DK.ADDITIONALLIGHT41,
            DK.ADDITIONALLIGHT42,
            DK.ADDITIONALLIGHT43,
            DK.ADDITIONALLIGHT44,
            DK.ADDITIONALLIGHT45,
            DK.ADDITIONALLIGHT46,
            DK.ADDITIONALLIGHT47,
            DK.ADDITIONALLIGHT48,
            DK.ADDITIONALLIGHT49,
            DK.ADDITIONALLIGHT50,
            DK.ADDITIONALLIGHT51,
            DK.ADDITIONALLIGHT52,
            DK.ADDITIONALLIGHT53,
            DK.ADDITIONALLIGHT54,
            DK.ADDITIONALLIGHT55,
            DK.ADDITIONALLIGHT56,
            DK.ADDITIONALLIGHT57,
            DK.ADDITIONALLIGHT58,
            DK.ADDITIONALLIGHT59,
            DK.ADDITIONALLIGHT60,
        };
    }
}
