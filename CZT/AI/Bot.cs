﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZT.Core;

namespace CZT.AI
{
    public class Bot : IPlayer
    {
        private int winCoef;
        private int loseCoef;
        private int neutralCoef;
        private Random rnd = new Random();

        public readonly int BotID;
        public readonly string Name;
        private Player botPlayer;
        private Game currentGame;

        public int Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string IPlayer.Name => throw new NotImplementedException();

        public int Id => throw new NotImplementedException();

        public Bot(Game game, Player father)
        {
            winCoef = 10;
            loseCoef = -10;
            neutralCoef = 1;
            BotID = father.Id;
            Name = father.Name;
            botPlayer = father;
            currentGame = game;
        }

        public void CalculateBestMove()
        {

        }

        public void RandomMove()
        {
            var x = rnd.Next(0, currentGame.CurrentLevel.width);
            var y = rnd.Next(0, currentGame.CurrentLevel.height);
            var point = new Point(x, y);
            if (!currentGame.CurrentLevel.settedPoints.Contains(point))
            {
                currentGame.CurrentLevel.Map[x, y] = BotID;
                return;
            }
            else RandomMove();
        }

        public void MakeMove(Level level)
        {
            throw new NotImplementedException();
        }
    }
}
