﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMCQsApp.Models
{
    public class Question
    {


        public int SNo;
        public string QuestionTitle { get; set; } = string.Empty;


        public string Topic { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = new List<string>();
        public string Answer { get; set; } = string.Empty;


        public int Time;
        public int Correct;
        public string Solution { get; set; } = string.Empty;


        public byte[]  Imagedata { get; set; }

        public byte[] Imagesol { get; set; }
    }
}
