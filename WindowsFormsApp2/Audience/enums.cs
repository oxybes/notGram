using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Audience
{
    public enum WhatPars
    {
        ID,
        Login,
        URI
    }

    public enum AudienceTask
    {
        AccSbor,
        HashTagSbor,
        Filter,
        DeleteDouble,
        Convert
    }

    public enum WhatAccPars
    {
        All,
        onlyPublic,
        onlyPrivate
    }

    public enum Sbor
    {
        Followers,
        Subscriptions
    }

    public enum TypePublish
    {
        All,
        Photo,
        Video
    }
}
