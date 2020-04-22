using System;
using TechTalk.SpecFlow;

namespace FrameworkWhite.Extensions
{
    public static class ScenarioContextExtension
    {
        public static T getValue<T>(this ScenarioContext context, string key)
        {
            if (context.ContainsKey(key))
            {
                return (T)context[key];
            }

            throw new Exception($"{key} is not defined!");
        }
    }
}
