﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            battlefield.RobotAttackDino();
            battlefield.DinoAttackRobot();
            battlefield.RobotAttackDino();
            battlefield.DinoAttackRobot();


        }
    }
}
