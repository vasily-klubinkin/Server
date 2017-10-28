﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Server.Models;

namespace Server
{
    class Program:IServerController
    {

        static void Main(string[] args)
        {
            Program server = new Program();

            server.StartServer();

            Console.ReadKey();
        }


        public void ServerController(EServer server)
        {
            //Bind server
            server.Initiallize();

            //Start server
            server.Start();

            //Start listening
            server.Handler();
        }

        //Initiallize Sockets(.ini files) + go to ServerController
        public void StartServer()
        {
            EServer server = new EServer();

            ServerController(server);
        }
    }
}
