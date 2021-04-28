using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models.User
{
    class Trainer
    {
        /// <summary>
        /// The groups in which the trainer is responsible for.
        /// </summary>
        List<string> Traininggroup { get; set; }
        /// <summary>
        /// Does the trainer have a motorboat certificate?
        /// </summary>
        bool MotorboatCert { get; set; }
        /// <summary>
        /// Which relevant fitness or rowing coach certifications have the trainer obtained?
        /// </summary>
        List<string> TrainerCertifications { get; set; }
        /// <summary>
        /// Which boats do the trainer in question command and can use with the groups he trains.
        /// </summary>
        List<string> BoatGoverment { get; set; }


    }
}
