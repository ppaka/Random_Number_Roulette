using Squirrel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SquirrelManager : MonoBehaviour
{
    private UpdateManager updateManager;

    void Start()
    {
        var task = Task.Run(() => CheckForUpdate());
    }

    private async Task CheckForUpdate()
    {
        _ = updateManager == await UpdateManager.GitHubUpdateManager(@"https://github.com/ppaka/Random_Number_Roulette", @"Random_Number_Roulette", null, null, true);

        var info = await updateManager.CheckForUpdate();

        await updateManager.DownloadReleases(info.ReleasesToApply);

        await updateManager.ApplyReleases(info);
    }
}
