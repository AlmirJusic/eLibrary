using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.Mob.Models
{
    public enum MenuItemType
    {
        Knjige,
        MojeKnjige,
        PredloziKnjigu,
        KorisnickiProfil,
        Logout,

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
