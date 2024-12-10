﻿using EasyAbp.PrivateMessaging.MainDemo.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace EasyAbp.PrivateMessaging.MainDemo.Settings;

public class MainDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AlphaSettings.MySetting1));

        //Gridin son filtre ayarlarını anımsa
        context.Add(new SettingDefinition(MainDemoSettings.RememberGridFilterState, "false", L("DisplayName:EasyAbp.PrivateMessaging.RememberGridFilterState"), L("Description:EasyAbp.PrivateMessaging.RememberGridFilterState")));
    }
    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MainDemoResource>(name);
    }
}