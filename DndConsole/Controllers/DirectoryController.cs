using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Models;

namespace DndConsole
{
    class DirectoryController
    {
        public string WorkingDirectory { get; private set; }
        public string PathToCampaign { get; private set; }
        public string PathToCharacters { get; private set; }
        public Campaign CurrentCampaign { get; private set; }
        public List<PlayerCharacter> CurrentCharacters { get; private set; }

        internal DirectoryController(Campaign campaign, List<PlayerCharacter> characters)
        {
            CurrentCampaign = campaign;
            CurrentCharacters = characters;
        }

        public bool ValidatePrimaryDirectory()
        {
            return 
                System.IO.Directory.Exists($"{System.Environment.SpecialFolder.MyDocuments}\\DnD");
        }

        public bool ValidateCampaignDirectory()
        {
            return
                System.IO.Directory.Exists($"{System.Environment.SpecialFolder.MyDocuments}\\DnD\\{CurrentCampaign}");
        }

        public bool ValidateDirectories()
        {
            bool isValid = ValidatePrimaryDirectory();
            isValid = ValidateCampaignDirectory();

            return isValid;
        }

        public bool SaveCampaign(Campaign campaign)
        {
            if (!ValidateDirectories())
                return false;

            //Do savey stuff

            return true;
        }

        public bool SaveCharacters(List<PlayerCharacter> characters)
        {
            if (!ValidateDirectories())
                return false;

            // Do savey stuff

            return true;
        }

        public bool LoadCampagin(Campaign campaign)
        {
            if (!ValidateDirectories())
                return false;

            // Do Loady stuff

            return true;
        }

        public bool LoadCharacters(List<PlayerCharacter> characters)
        {
            if (!ValidateDirectories())
                return false;

            // Do loady stuff

            return true;
        }
    }
}
