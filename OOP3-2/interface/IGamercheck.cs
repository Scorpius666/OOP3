﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_2.gamer.@interface
{
    interface IGamercheck:IFeelingcheck, IGamecheck
    {
        void Gamercheck();
    }
}
