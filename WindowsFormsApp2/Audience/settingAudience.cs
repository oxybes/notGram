using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Audience
{
    public class SettingAudience
    {
        public WhatAccPars SborAcc_WhatAccPars { get; set; }
        public  WhatPars SborAcc_WhatPars { get; set; }
        public int SborAcc_CountOneUser { get; set; }
        public string SborAcc_SaveFileName { get; set; }
        public Sbor SborAcc_Sbor { get; set; }
        public List<string> SborAcc_ListUserNames { get; set; }


        public WhatPars SborHashTags_WhatPars { get; set; }
        public bool SborHashTags_CheckedLikeUnderPublish { get; set; }
        public int SborHashTags_CountLikeUnderPublish_Min { get; set; }
        public int SborHashTags_CountLikeUnderPublish_Max { get; set; }
        public bool SborHashTags_CheckedCommentUnderPublish { get; set; }
        public int SborHashTags_CountCommentUnderPublish_Min { get; set; }
        public int SborHashTags_CountCommentUnderPublish_Max { get; set; }
        public TypePublish SborHashTags_TypePublish { get; set; }
        public string SborHashTags_SaveFileName { get; set; }
        public int SborHashTags_CountUneUser { get; set; }
        public List<string> SborHashTags_ListHashTags { get; set; }


        public string Filter_FileNameId { get; set; }
        public string Filter_SaveFileName { get; set; }
        public bool Filter_CheckedFollowers { get; set; }
        public int Filter_Followers_Min { get; set; }
        public int Filter_Followers_Max { get; set; }

        public bool Filter_CheckedSubscriptions { get; set; }
        public int Filter_Subscriptions_Min { get; set; }
        public int Filter_Subscriptions_Max { get; set; }

        public bool Filter_CheckedPublish { get; set; }
        public int Filter_Publish_Min { get; set; }
        public int Filter_Publish_Max { get; set; }

        public bool Filter_CheckedOldDays { get; set; }
        public int Filter_OldDays { get; set; }
        public WhatAccPars Filter_WhatAccPars { get; set; }
        public bool Filter_CheckedAvatar { get; set; }
        public bool Filter_CheckedBusines { get; set; }

        public string DeleteDouble_OriginalFileName { get; set; }
        public string DeleteDouble_SaveFileName { get; set; }

        public WhatPars Convert_OriginalPars { get; set; }
        public WhatPars Convert_NewPars { get; set; }
        public string Convert_OriginalFileName { get; set; }
        public  string Convert_SaveFileName { get; set; }


    }
}
