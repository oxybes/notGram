using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.SettingsTask
{
    internal interface  ISetting
    {
        bool CheckedNoAvatarUser { get; set; }
        bool CheckedPublicCountLess { get; set; }
        bool ChekedDeleteAdfter { get; set; }
        bool ChekedFollowsCountLess { get; set; }
        bool ChekedLikingBySubscribe { get; set; }
        bool ChekedPause { get; set; }
        bool ChekedSendPrivateUser { get; set; }
        bool ChekedSkipSubscriber { get; set; }
        bool ChekedSubscriptionsLess { get; set; }
        bool ChekedSubscriptionsMore { get; set; }
        bool ChekedUnSubscribeBlock { get; set; }
        bool ChekedUserBlock { get; set; }
        int CountCommnetUnderPublish { get; set; }
        int CountPublishComment { get; set; }
        int DelayMax { get; set; }
        int DelayMaxDop { get; set; }
        int DelayMin { get; set; }
        int DelayMinDop { get; set; }
        int FollowsCountLess { get; set; }
        int LikeAtUserMax { get; set; }
        int LikeAtUserMin { get; set; }
        int LikeUnderPublicMax { get; set; }
        int LikeUnderPublicMin { get; set; }
        int LikingMax { get; set; }
        int LikingMin { get; set; }
        int LimitSubscribe { get; set; }
        int PauseLimit { get; set; }
        int PauseTime { get; set; }
        int PublicCountLess { get; set; }
        int SubscriptionMore { get; set; }
        int SubscriptionsLess { get; set; }
        int UserBlock { get; set; }
        string FileNameBaseId { get; set; }
        string FileNameDontUnSubscribeId { get; set; }
        string WhatDoing { get; set; }
        string WhomClear { get; set; }
        string[] Message { get; set; }
    }


}
