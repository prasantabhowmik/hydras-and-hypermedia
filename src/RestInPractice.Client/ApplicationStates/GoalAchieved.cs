﻿using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RestInPractice.Client.ApplicationStates
{
    public class GoalAchieved : IApplicationState
    {
        private readonly HttpResponseMessage currentResponse;

        public GoalAchieved(HttpResponseMessage currentResponse)
        {
            this.currentResponse = currentResponse;
        }

        public IApplicationState NextState(HttpClient client)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage CurrentResponse
        {
            get { return currentResponse; }
        }

        public IEnumerable<Uri> History
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsTerminalState
        {
            get { return true; }
        }
    }
}