using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models.Logmonitor
{
    /// <summary>
    /// Logmonitor with additional sub-classes to categorize training properly. 
    /// Copyright 2015-2021 Logmonitor v.5.0 by Gorm F. Rasmussen - "gormrasmussen1990(at)gmail.com"
    /// </summary>
    class Logmonitor
    {
        /// <summary>
        /// LogID for the traininglog
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Username of the user which logged the trainingsession
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Is it LiT, ThT, or HiT?
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Which kind of activity is it? Running? Biking? ...
        /// </summary>
        public string Activity { get; set; }
        /// <summary>
        /// How many rounds of sets do you do?
        /// </summary>
        public int Bouts { get; set; }
        /// <summary>
        /// The date the training took place 
        /// </summary>
        public DateTime LogDate { get; set; }
        /// <summary>
        /// Borg Rating of Perceived Exertion scale. How hard a trainingpiece is on a scale from 1-10 where 1 is "Very light activity" and 10 is "Max efford activity"
        /// </summary>
        public int RPE { get; set; }
        /// <summary>
        /// How "recovered" you felt in general before doing the training-piece on a scale from 1-10 where 10 is completely recovered and 1 is not recovered at all
        /// </summary>
        public int PercievedRecovery { get; set; }
        /// <summary>
        /// How "recovered" you felt in your muscles before doing the training-piece on a scale from 1-10 where 10 is completely recovered and 1 is not recovered at all
        /// </summary>
        public int MuscleSoreness { get; set; }
        /// <summary>
        /// How much sleep you got before doing the training-piece on a scale from 1-10 where 10 is completely re-energised and 1 is not slept at all
        /// </summary>
        public int SleepQuantity { get; set; }
        /// <summary>
        /// How well you slept before doing the training-piece on a scale from 1-10 where 10 is completely re-energised and 1 is not slept at all
        /// </summary>
        public int StressLevel { get; set; }
        /// <summary>
        /// How much you feel like doing the trainingpiece on a scale from 1-10 where 10 is completely energized and 1 is without no energy at all
        /// </summary>
        public int Moodlevel { get; set; }
        /// <summary>
        /// Comments to the trainingpiece?
        /// </summary>
        public String Comments { get; set; }
    }
}
