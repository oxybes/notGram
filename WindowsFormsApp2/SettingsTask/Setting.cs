namespace WindowsFormsApp2.SettingsTask
{
    internal class Setting : ISetting
    {
        public bool CheckedNoAvatarUser { get; set; }
        public bool CheckedPublicCountLess { get; set; }
        public bool ChekedDeleteAdfter { get; set; }
        public bool ChekedFollowsCountLess { get; set; }
        public bool ChekedLikingBySubscribe { get; set; }
        public bool ChekedPause { get; set; }
        public bool ChekedSendPrivateUser { get; set; }
        public bool ChekedSkipSubscriber { get; set; }
        public bool ChekedSubscriptionsLess { get; set; }
        public bool ChekedSubscriptionsMore { get; set; }
        public bool ChekedUnSubscribeBlock { get; set; }
        public bool ChekedUserBlock { get; set; }
        public int CountCommnetUnderPublish { get; set; }
        public int CountPublishComment { get; set; }
        public int DelayMax { get; set; }
        public int DelayMaxDop { get; set; }
        public int DelayMin { get; set; }
        public int DelayMinDop { get; set; }
        public int FollowsCountLess { get; set; }
        public int LikeAtUserMax { get; set; }
        public int LikeAtUserMin { get; set; }
        public int LikeUnderPublicMax { get; set; }
        public int LikeUnderPublicMin { get; set; }
        public int LikingMax { get; set; }
        public int LikingMin { get; set; }
        public int LimitSubscribe { get; set; }
        public int PauseLimit { get; set; }
        public int PauseTime { get; set; }
        public int PublicCountLess { get; set; }
        public int SubscriptionMore { get; set; }
        public int SubscriptionsLess { get; set; }
        public int UserBlock { get; set; }
        public string FileNameBaseId { get; set; }
        public string FileNameDontUnSubscribeId { get; set; }
        public string WhatDoing { get; set; }
        public string WhomClear { get; set; }
        public string[] Message { get; set; }
    }
}