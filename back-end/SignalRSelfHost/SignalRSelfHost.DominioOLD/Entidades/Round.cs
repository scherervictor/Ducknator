﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRSelfHost.Dominio.Entidades
{
    public class Round
    {
        public List<MiniRound> MiniRounds { get; set; }
        public int Pontuacao { get; set; }
        public int QntdPatosMortos { get; set; }

        public Round()
        {
            GerarMiniRounds();
            Pontuacao = 0;
            QntdPatosMortos = 0;
        }

        public void GerarMiniRounds()
        {
            MiniRounds = new List<MiniRound>();
            for (int i = 0; i < 5; i++)
                MiniRounds.Add(new MiniRound());
        }
    }
}
