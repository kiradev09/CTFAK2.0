﻿using System.Collections.Generic;

namespace EventPreprocessor
{
    public class ActionNames
    {
        public static Dictionary<int, Dictionary<int, string>> systemDict =
    new Dictionary<int, Dictionary<int, string>>()
    {
        {
            -7, new Dictionary<int, string>()
            {

                {0, "SetScore"},
                {1, "SetLives"},
                {2, "IgnoreControls"},
                {3, "RestoreControls"},
                {4, "AddScore"},
                {5, "AddLives"},
                {6, "SubtractScore"},
                {7, "SubtractLives"},
                {8, "ChangeControlType"},
                {9, "ChangeInputKey"},
                {10, "SetPlayerName"}
            }
        },
        {
            -6, new Dictionary<int, string>()
            {
                {0, "HideCursor"},
                {1, "ShowCursor"}
            }
        },
        {
            -5, new Dictionary<int, string>()
            {
                {0, "CreateObject"},
                {1, "CreateObjectByName"}
            }
        },
        {
            -4, new Dictionary<int, string>()
            {
                {0, "SetTimer"},
                {1, "ScheduleEvent"},
                {2, "ScheduleEventTimes"}
            }
        },
        {
            -3, new Dictionary<int, string>()
            {
                {0, "NextFrame"},
                {1, "PreviousFrame"},
                {2, "JumpToFrame"},
                {3, "PauseApplication"},
                {4, "EndApplication"},
                {5, "RestartApplication"},
                {6, "RestartFrame"},
                {7, "CenterDisplay"},
                {8, "CenterDisplayX"},
                {9, "CenterDisplayY"},
                {10, "LOADGAME"},
                {11, "SAVEGAME"},
                {12, "ClearScreen"},
                {13, "ClearZone"},
                {14, "FullscreenMode"},
                {15, "WindowedMode"},
                {16, "SetFrameRate"},
                {17, "PauseApplicationWithKey"},
                {18, "PauseApplication"},
                {19, "EnableVsync"},
                {20, "DisableVsync"},
                {21, "SetVirtualWidth"},
                {22, "SetVirtualHeight"},
                {23, "SetFrameBackgroundColor"},
                {24, "DeleteCreatedBackdrops"},
                {25, "DeleteAllCreatedBackdrops"},
                {26, "SetFrameWidth"},
                {27, "SetFrameHeight"},
                {28, "SaveFrame"},
                {29, "LoadFrame"},
                {30, "LoadApplication"},
                {31, "PlayDemo"},
                {32, "SetFrameEffect"},
                {33, "SetFrameEffectParameter"},
                {34, "SetFrameEffectImage"},
                {35, "SetFrameAlphaCoefficient"},
                {36, "SetFrameRGBCoefficient"}
            }
        },
        {
            -2, new Dictionary<int, string>() //Sound and Music
            {
                {0, "PlaySample"},
                {1, "StopAllSamples"},
                {2, "PlayMusic"},
                {3, "StopMusic"},
                {4, "PlayLoopingSample"},
                {5, "PlayLoopingMusic"},
                {6, "StopSample"},
                {7, "PauseSample"},
                {8, "ResumeSample"},
                {9, "PauseMusic"},
                {10, "ResumeMusic"},
                {11, "PlayChannelSample"},
                {12, "PlayLoopingChannelSample"},
                {13, "PauseChannel"},
                {14, "ResumeChannel"},
                {15, "StopChannel"},
                {16, "SetChannelPosition"},
                {17, "SetChannelVolume"},
                {18, "SetChannelPan"},
                {19, "SetSamplePosition"},
                {20, "SetMainVolume"},
                {21, "SetSampleVolume"},
                {22, "SetMainPan"},
                {23, "SetSamplePan"},
                {24, "PauseAllSounds"},
                {25, "ResumeAllSounds"},
                {26, "PlayMusicFile"},
                {27, "PlayLoopingMusicFile"},
                {28, "PlayChannelFileSample"},
                {29, "PlayLoopingChannelFileSample"},
                {30, "LockChannel"},
                {31, "UnlockChannel"},
                {32, "SetChannelFrequency"},
                {33, "SetSampleFrequency"}
            }
        },
        {
            -1, new Dictionary<int, string>()
            {
                {0, "Skip"},
                {1, "SKIPMONITOR"},
                {2, "ExecuteFixedProgram"},
                {3, "SetGlobalValue"},
                {4, "SubtractGlobalValue"},
                {5, "AddGlobalValue"},
                {6, "ActivateGroup"},
                {7, "DeactivateGroup"},
                {8, "ActivateMenu"},
                {9, "DeactivateMenu"},
                {10, "CheckMenu"},
                {11, "UncheckMenu"},
                {12, "ShowMenu"},
                {13, "HideMenu"},
                {14, "StartLoop"},
                {15, "StopLoop"},
                {16, "SetLoopIndex"},
                {17, "SetRandomSeed"},
                {18, "SendMenuCommand"},
                {19, "SetGlobalString"},
                {20, "SetClipboard"},
                {21, "ClearClipboard"},
                {22, "ExecuteEvaluatedProgram"},
                {23, "OpenDebugger"},
                {24, "PauseDebugger"},
                {25, "ExtractBinaryFile"},
                {26, "ReleaseBinaryFile"},
                {27, "SetGlobalValueInt"},
                {28, "SetGlobalValue2"},
                {29, "SetGlobalValueDouble"},
                {30, "SetGlobalValue3"},
                {31, "AddGlobalValueInt"},
                {32, "AddGlobalValue2"},
                {33, "AddGlobalValueDouble"},
                {34, "AddGlobalValue3"},
                {35, "SubtractGlobalValueInt"},
                {36, "SubtractGlobalValue2"},
                {37, "SubtractGlobalValueDouble"},
                {38, "SubtractGlobalValue3"}
            }
        },
        {
            2, new Dictionary<int, string>()
            {
                {80, "PasteActive"},
                {81, "BringToFront"},
                {82, "BringToBack"},
                {83, "AddBackdrop"},
                {84, "ReplaceColor"},
                {85, "SetScale"},
                {86, "SetXScale"},
                {87, "SetYScale"},
                {88, "SetAngle"},
                {89, "LoadActiveFrame"}
            }
        },
        {
            3, new Dictionary<int, string>() //String
            {
                {80, "EraseText"},
                {81, "DisplayText"},
                {82, "FlashText"},
                {83, "SetTextColor"},
                {84, "SetParagraph"},
                {85, "PreviousParagraph"},
                {86, "NextParagraph"},
                {87, "DisplayAlterableString"},
                {88, "SetString"}
            }
        },
        {
            4, new Dictionary<int, string>()
            {
                {80, "AskQuestion"}
            }
        },
        {
            7, new Dictionary<int, string>()
            {
                {80, "SetCounterValue"},
                {81, "AddCounterValue"},
                {82, "SubtractCounterValue"},
                {83, "SetMinimumValue"},
                {84, "SetMaximumValue"},
                {85, "SetCounterColor1"},
                {86, "SetCounterColor2"}
            }
        },
        {
            8, new Dictionary<int, string>()
            {
                {80, "RTFSETXPOS"},
                {81, "RTFSETYPOS"},
                {82, "RTFSETZOOM"},
                {83, "RTFSELECT_CLEAR"},
                {84, "RTFSELECT_WORDSTRONCE"},
                {85, "RTFSELECT_WORDSTRNEXT"},
                {86, "RTFSELECT_WORDSTRALL"},
                {87, "RTFSELECT_WORD"},
                {88, "RTFSELECT_LINE"},
                {89, "RTFSELECT_PARAGRAPH"},
                {90, "RTFSELECT_PAGE"},
                {91, "RTFSELECT_ALL"},
                {92, "RTFSELECT_RANGE"},
                {93, "RTFSELECT_BOOKMARK"},
                {94, "RTFSETFOCUSWORD"},
                {95, "RTFHLIGHT_OFF"},
                {96, "RTFHLIGHTTEXT_COLOR"},
                {97, "RTFHLIGHTTEXT_BOLD"},
                {98, "RTFHLIGHTTEXT_ITALIC"},
                {99, "RTFHLIGHTTEXT_UNDERL"},
                {100, "RTFHLIGHTTEXT_OUTL"},
                {101, "RTFHLIGHTBACK_COLOR"},
                {102, "RTFHLIGHTBACK_RECT"},
                {103, "RTFHLIGHTBACK_MARKER"},
                {104, "RTFHLIGHTBACK_HATCH"},
                {105, "RTFHLIGHTBACK_INVERSE"},
                {106, "RTFDISPLAY"},
                {107, "RTFSETFOCUSPREV"},
                {108, "RTFSETFOCUSNEXT"},
                {109, "RTFREMOVEFOCUS"},
                {110, "RTFAUTOON"},
                {111, "RTFAUTOOFF"},
                {112, "RTFINSERTSTRING"},
                {113, "RTFLOADTEXT"},
                {114, "RTFINSERTTEXT"}
            }
        },
        {
            9, new Dictionary<int, string>()
            {
                {80, "RestartSubApplication"},
                {81, "RestartSubApplicationFrame"},
                {82, "NextSubApplicationFrame"},
                {83, "PreviousSubApplicationFrame"},
                {84, "EndSubApplication"},
                {85, "LoadApplication"},
                {86, "JumpSubApplicationFrame"},
                {87, "SetSubApplicationGlobalValue"},
                {88, "ShowSubApplication"},
                {89, "HideSubApplication"},
                {90, "SetSubApplicationGlobalString"},
                {91, "PauseSubApplication"},
                {92, "ResumeSubApplication"}
            }
        }
    };
public static Dictionary<int, string> extensionDict =
    new Dictionary<int, string>()
    {
        {1, "SetPosition"},
        {2, "SetX"},
        {3, "SetY"},
        {4, "Stop"},
        {5, "Start"},
        {6, "SetSpeed"},
        {7, "SetMaximumSpeed"},
        {8, "Wrap"},
        {9, "Bounce"},
        {10, "Reverse"},
        {11, "NextMovement"},
        {12, "PreviousMovement"},
        {13, "SelectMovement"},
        {14, "LookAt"},
        {15, "StopAnimation"},
        {16, "StartAnimation"},
        {17, "ForceAnimation"},
        {18, "ForceDirection"},
        {19, "ForceSpeed"},
        {20, "RestoreAnimation"},
        {21, "RestoreDirection"},
        {22, "RestoreSpeed"},
        {23, "SetDirection"},
        {24, "Destroy"},
        {25, "SwapPosition"},
        {26, "Hide"},
        {27, "Show"},
        {28, "FlashDuring"},
        {29, "Shoot"},
        {30, "ShootToward"},
        {31, "SetAlterableValue"},
        {32, "AddToAlterable"},
        {33, "SubtractFromAlterable"},
        {34, "SpreadValue"},
        {35, "EnableFlag"},
        {36, "DisableFlag"},
        {37, "ToggleFlag"},
        {38, "SetInkEffect"},
        {39, "SetSemiTransparency"},
        {40, "ForceFrame"},
        {41, "RestoreFrame"},
        {42, "SetAcceleration"},
        {43, "SetDeceleration"},
        {44, "SetRotatingSpeed"},
        {45, "SetDirections"},
        {46, "BranchNode"},
        {47, "SetGravity"},
        {48, "GoToNode"},
        {49, "SetAlterableString"},
        {50, "SetFontName"},
        {51, "SetFontSize"},
        {52, "SetBold"},
        {53, "SetItalic"},
        {54, "SetUnderline"},
        {55, "SetStrikeOut"},
        {56, "SetTextColor"},
        {57, "BringToFront"},
        {58, "BringToBack"},
        {59, "MoveBehind"},
        {60, "MoveInFront"},
        {61, "MoveToLayer"},
        {62, "AddToDebugger"},
        {63, "SetEffect"},
        {64, "SetEffectParameter"},
        {65, "SetAlphaCoefficient"},
        {66, "SetRGBCoefficient"},
        {67, "SetEffectImage"},
        {68, "SetFriction"},
        {69, "SetElasticity"},
        {70, "ApplyImpulse"},
        {71, "ApplyAngularImpulse"},
        {72, "ApplyForce"},
        {73, "ApplyTorque"},
        {74, "SetLinearVelocity"},
        {75, "SetAngularVelocity"},
        {76, "Foreach"},
        {77, "ForeachTwoObjects"},
        {78, "StopForce"},
        {79, "StopTorque"},
        {80, "SetDensity"},
        {81, "SetGravityScale"}
    };
    }
}