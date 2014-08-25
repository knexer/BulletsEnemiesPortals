using UnityEngine;
using System.Collections;
using System;

public class OptionsDictionary : MonoBehaviour {
    public static OptionsDictionary instance { get; private set; }

    public WorldType bulletWorld;
    public WorldType enemyWorld;
    public WorldType friendlyWorld;

    public GUISkin skin;
    private bool hasShowedMessage = false;
    private const int height = 600;
    private const int width = 600;

    private string startText;

	// Use this for initialization
	void Awake () {
        instance = this;
        WorldType[] worlds = gameObject.GetComponentsInChildren<WorldType>();

        System.Random gen = new System.Random();
        bulletWorld = worlds[gen.Next(worlds.Length)];
        enemyWorld = worlds[gen.Next(worlds.Length)];
        friendlyWorld = worlds[gen.Next(worlds.Length)];

        startText = populateText(flavorTexts[gen.Next(flavorTexts.Length)]);

        Debug.LogError("Bullet world: " + bulletWorld.worldName + " - Friendly world: " + friendlyWorld.worldName + " - Enemy world: " + enemyWorld.worldName);
	}

    void OnGUI() {
        if (!hasShowedMessage) {
            Time.timeScale = 0;
            Screen.lockCursor = false;
            GUI.skin = skin;
            GUI.Window(0, new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height), layoutWindow, "Let's Begin");
        }
    }

    public void layoutWindow(int id) {
        GUILayout.FlexibleSpace();

        GUILayout.Label(startText);

        GUILayout.FlexibleSpace();

        GUILayout.BeginHorizontal();
        GUILayout.Space(100);
        if (GUILayout.Button("Okay")) {
            hasShowedMessage = true;
            Time.timeScale = 1;
            Screen.lockCursor = true;
        }
        GUILayout.Space(100);
        GUILayout.EndHorizontal();
    }

    private string populateText(string orig) {
        string ret = orig;
        ret = ret.Replace("[bad]", enemyWorld.enemyName);
        ret = ret.Replace("[bads]", enemyWorld.enemyNamePlural);
        ret = ret.Replace("[good]", friendlyWorld.enemyName);
        ret = ret.Replace("[goods]", friendlyWorld.enemyNamePlural);
        ret = ret.Replace("[bullet]", bulletWorld.bulletName);
        ret = ret.Replace("[bullets]", bulletWorld.bulletNamePlural);

        ret = ret.Replace("[good world]", friendlyWorld.worldName);
        ret = ret.Replace("[bad world]", enemyWorld.worldName);
        ret = ret.Replace("[bullet world]", bulletWorld.worldName);

        ret = ret.Replace("[Bad]", capitalize(enemyWorld.enemyName));
        ret = ret.Replace("[Bads]", capitalize(enemyWorld.enemyNamePlural));
        ret = ret.Replace("[Good]", capitalize(friendlyWorld.enemyName));
        ret = ret.Replace("[Goods]", capitalize(friendlyWorld.enemyNamePlural));
        ret = ret.Replace("[Bullet]", capitalize(bulletWorld.bulletName));
        ret = ret.Replace("[Bullets]", capitalize(bulletWorld.bulletNamePlural));

        return ret;
    }

    private string capitalize(string s) {
        return char.ToUpper(s[0]) + s.Substring(1);
    }

    private string[] flavorTexts = new string[] {
        "The [bads] and the [goods] once lived together in relative harmony in [good world] Land - the [bads] in [Bad] Hollow to the north and the [goods] in [Good] Point to the south. But one morning, the [bads] awoke to find that all of their beloved [bullets] were mysteriously gone. Convinced that the [goods] had stolen them out of jealousy, they declared war. Little did they know that the true thief was a mischievous inter-dimensional being - you!\n\nOf course, you were just trying to have a little fun, but things have gotten a little out of hand. Only you, with your inexplicable ability to control portals to different dimensions, can appease the [bads] by returning their [bullets] and thereby prevent the [goods]’ annihilation. However, in order to end the violence for good, you must use the [bullets] to seal the portal the [bads] are using to access [Good] Point. Just be careful - the [goods] are very allergic to [bullets]. Don’t let the [bullets] touch the [goods] or they could die a horrible and gruesome death. Have fun!",
        "Planet [good world] is a prosperous world inhabited by [goods]. Their lives are easy and simple – except when they are running from deadly [bullets]. However, the more aggressive inhabitants of the nearby planet of [Bad] 5 want Planet [good world] to themselves, and have launched a full-scale invasion to conquer the peaceful world!\n\nThe [goods] are relying on their [bullet] redirection portals to destroy the [bad] drop ship and defend their home-world. But they need a skilled operator who can reliably aim the [bullets] at the [bads] without hitting friendly [goods]. Are you up to the task?",
        "[good world] City is a pleasant den of scum and villainy, and the home of the renowned Dirty [Good] gang. One day, after a delightful afternoon of intoxicated violence, the [Goods] decided to relax at their favorite bar, the Sticky [Bullet]. However, they shortly found themselves surrounded by a squad of fun-hating, portal-jumping [bad] cops.\n\nLuckily, the Sticky [Bullet] keeps a [bullet] stockpile for just such an occasion, conveniently located in a parallel dimension to deter counter-theft. All the [Goods] need from you is to keep them coming! Use the [bullets] to destroy the [bads]’ portal so the [Goods] can enjoy the rest of their day. Kill all the [bads] without hurting the [Goods] and you might even earn yourself a Dirty [Good] leather jacket. Let ‘em have it!",
    };
}
