﻿using acolumbaT5.Utils;


namespace acolumbaT5

{
    public partial class App : Application
    {
        public static PersonRepository personRepo { get; set; }

        public App(PersonRepository personRepository)
        {
            InitializeComponent();

            MainPage = new Views.vHome();
            personRepo = personRepository;
        }

    }
}
