﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class Partner
    {
        private int id;

        #region Private Fields

        private string _name;
        private string _telephone;
        private string _email;
        private string _city;
        private string _region;
        private string _regionShort;
        private string _timezone;

        #endregion

        #region Properties

        public string Name { get { return _name; } internal set { _name = value; } }
        public string Telephone { get { return _telephone; } internal set { _telephone = value; } }
        public string Email { get { return _email; } internal set { _email = value; } }
        public string City { get { return _city; } internal set { _city = value; } }
        public string Region { get { return _region; } internal set { _region = value; } }
        public string RegionShort { get { return _regionShort; } internal set { _regionShort = value; } }
        public string Timezone { get { return _timezone; } internal set { _timezone = value; } }

        #endregion

        internal Partner()
        {
            
        }
        internal Partner(int id, string name, string telephone, string email, string city, string region, string regionShort, string timeZone)
        {
            this.id = id;
            _name = name;
            _telephone = telephone;
            _email = email;
            _city = city;
            _region = region;
            _regionShort = regionShort;
            _timezone = timeZone;
        }

        #region Methods

        #endregion
    }
}