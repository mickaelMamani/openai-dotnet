// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Moderations
{
    internal partial class InternalModerationCategoryScores
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalModerationCategoryScores(float hate, float hateThreatening, float harassment, float harassmentThreatening, float selfHarm, float selfHarmIntent, float selfHarmInstructions, float sexual, float sexualMinors, float violence, float violenceGraphic)
        {
            Hate = hate;
            HateThreatening = hateThreatening;
            Harassment = harassment;
            HarassmentThreatening = harassmentThreatening;
            SelfHarm = selfHarm;
            SelfHarmIntent = selfHarmIntent;
            SelfHarmInstructions = selfHarmInstructions;
            Sexual = sexual;
            SexualMinors = sexualMinors;
            Violence = violence;
            ViolenceGraphic = violenceGraphic;
        }

        internal InternalModerationCategoryScores(float hate, float hateThreatening, float harassment, float harassmentThreatening, float selfHarm, float selfHarmIntent, float selfHarmInstructions, float sexual, float sexualMinors, float violence, float violenceGraphic, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Hate = hate;
            HateThreatening = hateThreatening;
            Harassment = harassment;
            HarassmentThreatening = harassmentThreatening;
            SelfHarm = selfHarm;
            SelfHarmIntent = selfHarmIntent;
            SelfHarmInstructions = selfHarmInstructions;
            Sexual = sexual;
            SexualMinors = sexualMinors;
            Violence = violence;
            ViolenceGraphic = violenceGraphic;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalModerationCategoryScores()
        {
        }

        public float Hate { get; }
        public float HateThreatening { get; }
        public float Harassment { get; }
        public float HarassmentThreatening { get; }
        public float SelfHarm { get; }
        public float SelfHarmIntent { get; }
        public float SelfHarmInstructions { get; }
        public float Sexual { get; }
        public float SexualMinors { get; }
        public float Violence { get; }
        public float ViolenceGraphic { get; }
    }
}