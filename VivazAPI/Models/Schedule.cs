﻿using System;
using VivazAPI.Dtos;

namespace VivazAPI.Models
{
    public class Schedule : BaseEntity
    {
        //User
        public Guid EmployeeId { get; set; }
        public UserReadDto Employee { get; set; }
        //Occurence
        public Guid OccurenceId { get; set; }        
        public OccurrenceWithDetailsReadDto Occurence { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
    }
}