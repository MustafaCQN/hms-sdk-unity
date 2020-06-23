﻿namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class GameSummaryClientWrapper : JavaObjectWrapper, IGameSummaryClient
    {
        [UnityEngine.Scripting.Preserve]
        public static GameSummaryClientWrapper NewInstance(AndroidJavaObject javaObject) => new GameSummaryClientWrapper(javaObject);

        public GameSummaryClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<GameSummary> LocalGameSummary => CallAsWrapper<TaskJavaObjectWrapper<GameSummary>>("getLocalGameSummary");

        public ITask<GameSummary> GameSummary => CallAsWrapper<TaskJavaObjectWrapper<GameSummary>>("getGameSummary");
    }
}
