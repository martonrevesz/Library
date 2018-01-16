using SimbaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.ViewModels
{
    public class ReaderCardViewModel
    {
        public List<Reader> ReaderList = new List<Reader>();

        public ReaderCardViewModel()
        {
            InitReaderCardList();
        }

        private void InitReaderCardList()
        {
            ReaderList.Add(new Reader()
            {
                Name = "Süvi",
                Fine = 0,
                UserType = "Mentor",
                VIP = true
            });
            ReaderList.Add(new Reader()
            {
                Name = "Gabor",
                Fine = 30,
                UserType = "mentor"
            });
            ReaderList.Add(new Reader()
            {
                Name = "Misi",
                Fine = 0,
                UserType = "student"
            });
            ReaderList.Add(new Reader()
            {
                Name = "Samu",
                Fine = 50,
                UserType = "partner"
            });
            ReaderList.Add(new Reader()
            {
                Name = "Balint",
                Fine = 20,
                UserType = "student",
                VIP = true
            });
        }
    }
}
