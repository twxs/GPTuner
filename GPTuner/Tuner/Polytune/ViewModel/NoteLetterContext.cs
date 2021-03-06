﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuner.Polytune.Model;
using Tuner.TunerMockup.Model;

namespace Tuner.Polytune.ViewModel
{
    class NoteLetterContext : TunerContext
    {

        public static int LEDS_WIDTH = 7;
        public static int LEDS_HEIGHT = 6;

        #region Notes

        private static bool[,] NoneLeds = {
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               };

        private static bool[,] ALeds = { 
                               {false, false, false, false, false, false, false,},
                               {false, true, true, false, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, true, true, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               };

        private static bool[,] ASharpLeds = { 
                               {false, false, false, false, false, true, true,},
                               {false, true, true, false, false, true, true,},
                               {true, false, false, true, false, false, false,},
                               {true, true, true, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               };

        private static bool[,] BLeds = { 
                               {false, false, false, false, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               };

        private static bool[,] BSharpLeds = { 
                               {false, false, false, false, false, true, true,},
                               {true, true, true, false, false, true, true,},
                               {true, false, false, true, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               };

        private static bool[,] CLeds = { 
                               {false, false, false, false, false, false, false,},
                               {false, true, true, true, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {false, true, true, true, false, false, false,},
                               };

        private static bool[,] CSharpLeds = { 
                               {false, false, false, false, false, true, true,},
                               {false, true, true, true, false, true, true,},
                               {true, false, false, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {false, true, true, true, false, false, false,},
                               };

        private static bool[,] DLeds = { 
                               {false, false, false, false, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               };

        private static bool[,] DSharpLeds = { 
                               {false, false, false, false, false, true, true,},
                               {true, true, true, false, false, true, true,},
                               {true, false, false, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               };

        private static bool[,] ELeds = { 
                               {false, false, false, false, false, false, false,},
                               {true, true, true, true, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, true, true, true, false, false, false,},
                               };

        private static bool[,] FLeds = { 
                               {false, false, false, false, false, false, false,},
                               {true, true, true, true, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               };

        private static bool[,] FSharpLeds = { 
                               {false, false, false, false, false, true, true,},
                               {true, true, true, true, false, true, true,},
                               {true, false, false, false, false, false, false,},
                               {true, true, true, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               };

        private static bool[,] GLeds = { 
                               {false, false, false, false, false, false, false,},
                               {false, true, true, true, false, false, false,},
                               {true, false, false, false, false, false, false,},
                               {true, false, true, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {false, true, true, false, false, false, false,},
                               };

        private static bool[,] GSharpLeds = { 
                               {false, false, false, false, false, true, true,},
                               {false, true, true, true, false, true, true,},
                               {true, false, false, false, false, false, false,},
                               {true, false, true, true, false, false, false,},
                               {true, false, false, true, false, false, false,},
                               {false, true, true, false, false, false, false,},
                               };

        private static bool[,] SquareLeds = { 
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               {false, false, false, false, false, false, false,},
                               {false, false, false, true, false, false, false,},
                               };




        #endregion

        public NoteLetterContext()
            : base()
        {
            notesMap = new Dictionary<double, NoteLetters>();
            initializeNotesMap();
        }

        private void initializeNotesMap()
        {
            notesMap.Add(40, NoteLetters.E);
            notesMap.Add(45, NoteLetters.A);
            notesMap.Add(50, NoteLetters.D);
            notesMap.Add(55, NoteLetters.G);
            notesMap.Add(59, NoteLetters.B);
            notesMap.Add(64, NoteLetters.E);
        }

        private PlayedNote note;
        /// <summary>
        /// Note jouée
        /// </summary>
        public PlayedNote Note
        {
            get { return note; }
            set
            {
                note = value;
                updateDelsList();
            }
        }

        private Dictionary<double, NoteLetters> notesMap;

        protected override void updateDelsList()
        {
            bool[,] toBeDisplayed;
            if (Note != null)
            {
                toBeDisplayed = getNoteArrayData(notesMap[Note.TargetedNote]);
            }
            else
            {
                toBeDisplayed = NoneLeds;
            }
            List<DelModel>[] delsColumns = new List<DelModel>[LEDS_WIDTH];

            // TODO
            for (int i = LEDS_WIDTH-1; i >= 0 ; i--)
            {
                List<DelModel> delColumn = new List<DelModel>();
                for (int j = LEDS_HEIGHT-1; j >= 0 ; j--)
                {
                    DelModel delModel = new DelModel();
                    delModel.On = toBeDisplayed[j, i];
                    delModel.Level = toBeDisplayed[j, i] ? Del.LEVEL_WRONG : Del.LEVEL_0;
                    delColumn.Add(delModel);
                }
                delsColumns[i] = delColumn;
            }

            // Mettre à jour les Dels
            DelsList.Clear();
            foreach (List<DelModel> lst in delsColumns)
            {
                DelsList.Add(lst);
            }
        }

        public enum NoteLetters { None, A, ASharp, B, BSharp, C, CSharp, D, DSharp, E, F, FSharp, G, GSharp, Square };

        private static bool[][,] correspondances = { NoneLeds, ALeds, ASharpLeds, BLeds, BSharpLeds, CLeds, CSharpLeds, DLeds, DSharpLeds, ELeds, FLeds, FSharpLeds, GLeds, GSharpLeds, SquareLeds };

        #region Private methods

        private bool[,] getNoteArrayData(NoteLetters note)
        {
            return correspondances[(int)note];
        }

        #endregion

        protected override void OnNbStringsChanged()
        {
            // Rien
        }

        protected override void OnScreenHeightChanged()
        {
            // Rien
        }

        protected override void OnScreenWidthChanged()
        {
            // Rien
        }
    }
}
