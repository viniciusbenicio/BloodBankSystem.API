﻿using BloodBankSystem.Core;
using System.Net.Sockets;

namespace BloodBankSystem.Application.Models;


public class CreateDonnorInputModel
{
    public string FullName { get;  set; }
    public string Email { get;  set; }
    public DateTime DateOfBirth { get;  set; }
    public string Gender { get;  set; }
    public double Weight { get;  set; }
    public string BloodType { get;  set; }
    public string HRFactor { get;  set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
   
    public Donor ToEntity()
          => new(FullName, Email, DateOfBirth, Gender, Weight, BloodType, HRFactor, Street, City, State, ZipCode);
}
