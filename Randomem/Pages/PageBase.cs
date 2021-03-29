using MemeLib;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Randomem.Pages
{
    public class PageBase : ComponentBase
    {
        public string memeUrl { get; set; }
        public void GetUrl()
        {
            memeUrl = MemeUrl.DrawUrl();
        }

        protected override Task OnInitializedAsync()
        {
            GetUrl();
            return base.OnInitializedAsync();
        }


    }
}
