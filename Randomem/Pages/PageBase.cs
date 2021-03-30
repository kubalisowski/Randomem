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
        public Queue<string> memeQueue { get; set; } = new Queue<string>();

        public void GetUrl()
        {
            memeUrl = memeQueue.Dequeue();
        }
        //public void GetUrl()
        //{
        //    if (memeQueue.Count > 1)
        //    {
        //        memeUrl = memeQueue.Dequeue();
        //    }
        //    else if (memeQueue.Count == 1)
        //    {
        //        memeQueue.Enqueue(MemeUrl.DrawUrl());
        //        memeUrl = memeQueue.Dequeue();
        //    }
        //    else
        //    {
        //        GetMemes();
        //        memeUrl = memeQueue.Dequeue();
        //    }
        //}

        public void GetMemes()
        {
            for (int i = 0; i < 2; i++)
            {
                memeQueue.Enqueue(MemeUrl.DrawUrl());
            }
        }
        
        protected override Task OnInitializedAsync()
        {
            memeUrl = MemeUrl.DrawUrl();
            GetMemes();
            return base.OnInitializedAsync();
        }


    }
}
