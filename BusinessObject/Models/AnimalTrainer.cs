using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class AnimalTrainer
{
    public int Id { get; set; }

    public int? AnimalId { get; set; }

    public int? ZooTrainerId { get; set; }
}
