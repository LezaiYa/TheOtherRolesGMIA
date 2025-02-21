using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;
using TheOtherRoles.Utilities;
using TheOtherRoles.CustomGameModes;
using Reactor.Networking;

namespace TheOtherRoles
{
    public class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isModifier;

        public RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        public static RoleInfo jester = new RoleInfo(ModTranslation.getString("jester"), Jester.color, ModTranslation.getString("jesterIntroDesc"), ModTranslation.getString("jesterShortDesc"), RoleId.Jester, true);
        public static RoleInfo mayor = new RoleInfo(ModTranslation.getString("mayor"), Mayor.color, ModTranslation.getString("mayorIntroDesc"), ModTranslation.getString("mayorShortDesc"), RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo("Portalmaker", Portalmaker.color, "You can create portals", "You can create portals", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo(ModTranslation.getString("engineer"),  Engineer.color, ModTranslation.getString("engineerIntroDesc"), ModTranslation.getString("engineerShortDesc"), RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo(ModTranslation.getString("sheriff"), Sheriff.color, ModTranslation.getString("sheriffIntroDesc"), ModTranslation.getString("sheriffShortDesc"), RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo(ModTranslation.getString("deputy"), Sheriff.color, ModTranslation.getString("deputyIntroDesc"), ModTranslation.getString("deputyShortDesc"), RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo(ModTranslation.getString("lighter"), Lighter.color, ModTranslation.getString("lighterIntroDesc"), ModTranslation.getString("lighterShortDesc"), RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo(ModTranslation.getString("godfather"), Godfather.color, ModTranslation.getString("godfatherIntroDesc"), ModTranslation.getString("godfatherShortDesc"), RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo(ModTranslation.getString("mafioso"), Mafioso.color, ModTranslation.getString("mafiosoIntroDesc"), ModTranslation.getString("mafiosoShortDesc"), RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo(ModTranslation.getString("janitor"), Janitor.color, ModTranslation.getString("janitorIntroDesc"), ModTranslation.getString("janitorShortDesc"), RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo(ModTranslation.getString("morphling"), Morphling.color, ModTranslation.getString("morphlingIntroDesc"), ModTranslation.getString("morphlingShortDesc"), RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo(ModTranslation.getString("camouflager"), Camouflager.color, ModTranslation.getString("camouflagerIntroDesc"), ModTranslation.getString("camouflagerShortDesc"), RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo(ModTranslation.getString("vampire"), Vampire.color, ModTranslation.getString("vampireIntroDesc"), ModTranslation.getString("vampireShortDesc"), RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo(ModTranslation.getString("eraser"), Eraser.color, ModTranslation.getString("eraserIntroDesc"), ModTranslation.getString("eraserShortDesc"), RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo(ModTranslation.getString("trickster"), Trickster.color, ModTranslation.getString("tricksterIntroDesc"), ModTranslation.getString("tricksterShortDesc"), RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo(ModTranslation.getString("cleaner"), Cleaner.color, ModTranslation.getString("cleanerIntroDesc"), ModTranslation.getString("cleanerShortDesc"), RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo(ModTranslation.getString("warlock"), Warlock.color, ModTranslation.getString("warlockIntroDesc"), ModTranslation.getString("warlockShortDesc"), RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo(ModTranslation.getString("bountyHunter"), BountyHunter.color, ModTranslation.getString("bountyHunterIntroDesc"), ModTranslation.getString("bountyHunterShortDesc"), RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo(ModTranslation.getString("detective"), Detective.color, ModTranslation.getString("detectiveIntroDesc"), ModTranslation.getString("detectiveShortDesc"), RoleId.Detective);
        public static RoleInfo bait = new RoleInfo(ModTranslation.getString("bait"), Bait.color, ModTranslation.getString("baitIntroDesc"), ModTranslation.getString("baitShortDesc"), RoleId.Bait);
        public static RoleInfo timeMaster = new RoleInfo(ModTranslation.getString("timeMaster"), TimeMaster.color, ModTranslation.getString("timeMasterIntroDesc"), ModTranslation.getString("timeMasterShortDesc"), RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo(ModTranslation.getString("medic"), Medic.color, ModTranslation.getString("medicIntroDesc"), ModTranslation.getString("medicShortDesc"), RoleId.Medic);
        public static RoleInfo niceSwapper = new RoleInfo(ModTranslation.getString("niceSwapper"), Swapper.color, ModTranslation.getString("swapperIntroDesc"), ModTranslation.getString("swapperShortDesc"), RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo(ModTranslation.getString("seer"), Seer.color, ModTranslation.getString("seerIntroDesc"), ModTranslation.getString("seerShortDesc"), RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo(ModTranslation.getString("hacker"), Hacker.color, ModTranslation.getString("hackerIntroDesc"), ModTranslation.getString("hackerShortDesc"), RoleId.Hacker);
        public static RoleInfo niceshifter = new RoleInfo(ModTranslation.getString("shifter"), Shifter.color, ModTranslation.getString("shifterIntroDesc"), ModTranslation.getString("shifterShortDesc"), RoleId.Shifter);
        public static RoleInfo tracker = new RoleInfo(ModTranslation.getString("tracker"), Tracker.color, ModTranslation.getString("trackerIntroDesc"), ModTranslation.getString("trackerShortDesc"), RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo(ModTranslation.getString("snitch"), Snitch.color, ModTranslation.getString("snitchIntroDesc"), ModTranslation.getString("snitchShortDesc"), RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("Jackal", Jackal.color, "Kill all Crewmates and <color=#FF1919FF>Impostors</color> to win", "Kill everyone", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("Sidekick", Sidekick.color, "Help your Jackal to kill everyone", "Help your Jackal to kill everyone", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo(ModTranslation.getString("spy"), Spy.color, ModTranslation.getString("spyIntroDesc"), ModTranslation.getString("spyShortDesc"), RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo(ModTranslation.getString("securityGuard"), SecurityGuard.color, ModTranslation.getString("securityGuardIntroDesc"), ModTranslation.getString("securityGuardShortDesc"), RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo(ModTranslation.getString("arsonist"), Arsonist.color, ModTranslation.getString("arsonistIntroDesc"), ModTranslation.getString("arsonistShortDesc"), RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo(ModTranslation.getString("niceGuesser"), Guesser.color, ModTranslation.getString("niceGuesserIntroDesc"), ModTranslation.getString("niceGuesserShortDesc"), RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo(ModTranslation.getString("evilGuesser"), Palette.ImpostorRed, ModTranslation.getString("evilGuesserIntroDesc"), ModTranslation.getString("evilGuesserShortDesc"), RoleId.EvilGuesser);
        public static RoleInfo niceWatcher = new RoleInfo(ModTranslation.getString("niceWatcher"), Watcher.color, ModTranslation.getString("niceWatcherIntroDesc"), ModTranslation.getString("niceWatcherShortDesc"), RoleId.NiceWatcher);
        public static RoleInfo evilWatcher = new RoleInfo(ModTranslation.getString("evilWatcher"), Palette.ImpostorRed, ModTranslation.getString("evilWatcherIntroDesc"), ModTranslation.getString("evilWatcherShortDesc"), RoleId.EvilWatcher);
        public static RoleInfo vulture = new RoleInfo(ModTranslation.getString("vulture"), Vulture.color, ModTranslation.getString("vultureIntroDesc"), ModTranslation.getString("vultureShortDesc"), RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo(ModTranslation.getString("medium"), Medium.color, ModTranslation.getString("mediumIntroDesc"), ModTranslation.getString("mediumShortDesc"), RoleId.Medium);
        //public static RoleInfo trapper = new RoleInfo("Trapper", Trapper.color, "Place traps to find the Impostors", "Place traps", RoleId.Trapper);
        public static RoleInfo lawyer = new RoleInfo(ModTranslation.getString("lawyer"), Lawyer.color, ModTranslation.getString("lawyerIntroDesc"), ModTranslation.getString("lawyerShortDesc"), RoleId.Lawyer, true);
        //public static RoleInfo prosecutor = new RoleInfo("Prosecutor", Lawyer.color, "Vote out your target", "Vote out your target", RoleId.Prosecutor, true);
        public static RoleInfo pursuer = new RoleInfo(ModTranslation.getString("pursuer"), Pursuer.color, ModTranslation.getString("pursuerIntroDesc"), ModTranslation.getString("pursuerShortDesc"), RoleId.Pursuer, true);
        public static RoleInfo impostor = new RoleInfo("Impostor", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "Sabotage and kill everyone"), "Sabotage and kill everyone", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("Crewmate", Color.white, "Find the Impostors", "Find the Impostors", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo(ModTranslation.getString("witch"), Witch.color, ModTranslation.getString("witchIntroDesc"), ModTranslation.getString("witchShortDesc"), RoleId.Witch);
        public static RoleInfo assassin = new RoleInfo(ModTranslation.getString("assassin"), Assassin.color, ModTranslation.getString("assassinIntroDesc"), ModTranslation.getString("assassinShortDesc"), RoleId.Assassin);
        public static RoleInfo thief = new RoleInfo("Thief", Thief.color, "Steal a killers role by killing them", "Steal a killers role", RoleId.Thief, true);
        //public static RoleInfo bomber = new RoleInfo("Bomber", Bomber.color, "Bomb all Crewmates", "Bomb all Crewmates", RoleId.Bomber);

        // GMIA functional
        public static RoleInfo ninja = new RoleInfo(ModTranslation.getString("ninja"), Ninja.color, ModTranslation.getString("ninjaIntroDesc"), ModTranslation.getString("ninjaShortDesc"), RoleId.Ninja);
        public static RoleInfo nekoKabocha = new RoleInfo(ModTranslation.getString("nekoKabocha"), NekoKabocha.color, ModTranslation.getString("nekoKabochaIntroDesc"), ModTranslation.getString("nekoKabochaShortDesc"), RoleId.NekoKabocha);
        public static RoleInfo serialKiller = new RoleInfo(ModTranslation.getString("serialKiller"), SerialKiller.color, ModTranslation.getString("serialKillerIntroDesc"), ModTranslation.getString("serialKillerShortDesc"), RoleId.SerialKiller);
        public static RoleInfo evilTracker = new RoleInfo(ModTranslation.getString("evilTracker"), EvilTracker.color, ModTranslation.getString("evilTrackerIntroDesc"), ModTranslation.getString("evilTrackerShortDesc"), RoleId.EvilTracker);
        public static RoleInfo undertaker = new RoleInfo(ModTranslation.getString("undertaker"), Undertaker.color, ModTranslation.getString("undertakerIntroDesc"), ModTranslation.getString("undertakerIntroDesc"), RoleId.Undertaker);
        public static RoleInfo mimicK = new RoleInfo(ModTranslation.getString("mimicK"), MimicK.color, ModTranslation.getString("mimicKIntroDesc"), ModTranslation.getString("mimicKShortDesc"), RoleId.MimicK);
        public static RoleInfo mimicA = new RoleInfo(ModTranslation.getString("mimicA"), MimicA.color, ModTranslation.getString("mimicAIntroDesc"), ModTranslation.getString("mimicAShortDesc"), RoleId.MimicA);
        public static RoleInfo bomberA = new RoleInfo(ModTranslation.getString("bomber"), BomberA.color, ModTranslation.getString("bomberIntroDesc"), ModTranslation.getString("bomberShortDesc"), RoleId.BomberA);
        public static RoleInfo bomberB = new RoleInfo(ModTranslation.getString("bomber"), BomberB.color, ModTranslation.getString("bomberIntroDesc"), ModTranslation.getString("bomberShortDesc"), RoleId.BomberB);
        public static RoleInfo evilSwapper = new RoleInfo(ModTranslation.getString("evilSwapper"), Palette.ImpostorRed, ModTranslation.getString("evilSwapperIntroDesc"), ModTranslation.getString("evilSwapperShortDesc"), RoleId.Swapper);
        public static RoleInfo fortuneTeller = new RoleInfo(ModTranslation.getString("fortuneTeller"), FortuneTeller.color, ModTranslation.getString("fortuneTellerIntroDesc"), ModTranslation.getString("fortuneTellerShortDesc"), RoleId.FortuneTeller);
        public static RoleInfo veteran = new RoleInfo(ModTranslation.getString("veteran"), Veteran.color, ModTranslation.getString("veteranIntroDesc"), ModTranslation.getString("veteranShortDesc"), RoleId.Veteran);
        public static RoleInfo sprinter = new RoleInfo(ModTranslation.getString("sprinter"), Sprinter.color, ModTranslation.getString("sprinterIntroDesc"), ModTranslation.getString("sprinterShortDesc"), RoleId.Sprinter);
        public static RoleInfo sherlock = new RoleInfo(ModTranslation.getString("sherlock"), Sherlock.color, ModTranslation.getString("sherlockIntroDesc"), ModTranslation.getString("sherlockShortDesc"), RoleId.Sherlock);
        public static RoleInfo yasuna = new RoleInfo("Yasuna", Yasuna.color, "Exile suspicious Crewmates", "Exile suspicious Crewmates", RoleId.Yasuna);
        public static RoleInfo taskMaster = new RoleInfo("Task Master", TaskMaster.color, "Complete all extra tasks to win", "Complete all extra tasks", RoleId.TaskMaster);
        public static RoleInfo evilYasuna = new RoleInfo("Evil Yasuna", Palette.ImpostorRed, "Exile smart Crewmates", "Exile smart Crewmates", RoleId.EvilYasuna);
        public static RoleInfo opportunist = new RoleInfo(ModTranslation.getString("opportunist"), Opportunist.color, ModTranslation.getString("opportunistIntroDesc"), ModTranslation.getString("opportunistShortDesc"), RoleId.Opportunist, true);
        public static RoleInfo chainshifter = new RoleInfo(ModTranslation.getString("corruptedShifter"), Shifter.color, ModTranslation.getString("corruptedShifterIntroDesc"), ModTranslation.getString("corruptedShifterShortDesc"), RoleId.Shifter, true);

        public static RoleInfo hunter = new RoleInfo("Hunter", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "Seek and kill everyone"), "Seek and kill everyone", RoleId.Impostor);
        public static RoleInfo hunted = new RoleInfo("Hunted", Color.white, "Hide", "Hide", RoleId.Crewmate);



        // Modifier
        public static RoleInfo bloody = new RoleInfo("Bloody", Color.yellow, "Your killer leaves a bloody trail", "Your killer leaves a bloody trail", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("Anti tp", Color.yellow, "You will not get teleported", "You will not get teleported", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("Tiebreaker", Color.yellow, "Your vote breaks the tie", "Break the tie", RoleId.Tiebreaker, false, true);
        //public static RoleInfo bait = new RoleInfo("Bait", Color.yellow, "Bait your enemies", "Bait your enemies", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("Sunglasses", Color.yellow, "You got the sunglasses", "Your vision is reduced", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("Lover", Lovers.color, $"You are in love", $"You are in love", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("Mini", Color.yellow, "No one will harm you until you grow up", "No one will harm you", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("VIP", Color.yellow, "You are the VIP", "Everyone is notified when you die", RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo("Invert", Color.yellow, "Your movement is inverted", "Your movement is inverted", RoleId.Invert, false, true);
        public static RoleInfo chameleon = new RoleInfo("Chameleon", Color.yellow, "You're hard to see when not moving", "You're hard to see when not moving", RoleId.Chameleon, false, true);
        //public static RoleInfo shifter = new RoleInfo("Shifter", Color.yellow, "Shift your role", "Shift your role", RoleId.Shifter, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            witch,
            assassin,
            ninja,
            nekoKabocha,
            serialKiller,
            evilTracker,
            evilSwapper,
            undertaker,
            mimicK,
            mimicA,
            bomberA,
            bomberB,
            evilYasuna,
            //bomber,
            goodGuesser,
            badGuesser,
            evilWatcher,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            thief,
            opportunist,
            chainshifter,
            //prosecutor,
            crewmate,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            niceshifter, 
            bait,
            lighter,
            detective,
            timeMaster,
            medic,
            niceSwapper,
            niceWatcher,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            medium,
            fortuneTeller,
            sprinter,
            veteran,
            sherlock,
            yasuna,
            taskMaster,
            //trapper,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert,
            chameleon,
            //shifter, 
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true, bool includeHidden = false) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead || AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Ended)
                {
                    //if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
                if (Chameleon.chameleon.Any(x => x.PlayerId == p.PlayerId)) infos.Add(chameleon);
                //if (p == Shifter.shifter) infos.Add(shifter);
            }

            int count = infos.Count;  // Save count after modifiers are added so that the role count can be checked

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Assassin.assassin) infos.Add(assassin);
            //if (p == Bomber.bomber) infos.Add(bomber);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Swapper.swapper) infos.Add(p.Data.Role.IsImpostor ? evilSwapper : niceSwapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Bait.bait) infos.Add(bait);
            if (p == Veteran.veteran) infos.Add(veteran);
            if (p == Sherlock.sherlock) infos.Add(sherlock);
            if (p == Sprinter.sprinter) infos.Add(sprinter);
            if (p == Yasuna.yasuna) infos.Add(p.Data.Role.IsImpostor ? evilYasuna : yasuna);
            if (p == FortuneTeller.fortuneTeller)
            {
                if (PlayerControl.LocalPlayer.Data.IsDead || includeHidden)
                {
                    infos.Add(fortuneTeller);
                }
                else
                {
                    var info = FortuneTeller.isCompletedNumTasks(p) ? fortuneTeller : crewmate;
                    infos.Add(info);
                }
            }
            if (p == TaskMaster.taskMaster)
            {
                if (CachedPlayer.LocalPlayer.PlayerControl.Data.IsDead || includeHidden || !TaskMaster.becomeATaskMasterWhenCompleteAllTasks) infos.Add(taskMaster);
                else infos.Add(TaskMaster.isTaskComplete ? taskMaster : crewmate);
            }
            if (p == Opportunist.opportunist) infos.Add(opportunist);
            if (p == Shifter.shifter) infos.Add(Shifter.isNeutral ? chainshifter : niceshifter);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
            if (p == Guesser.evilGuesser) infos.Add(badGuesser);
            if (p == Watcher.nicewatcher) infos.Add(niceWatcher);
            if (p == Watcher.evilwatcher) infos.Add(evilWatcher);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == NekoKabocha.nekoKabocha) infos.Add(nekoKabocha);
            if (p == SerialKiller.serialKiller) infos.Add(serialKiller);
            if (p == EvilTracker.evilTracker) infos.Add(evilTracker);
            if (p == Undertaker.undertaker) infos.Add(undertaker);
            if (p == MimicK.mimicK) infos.Add(mimicK);
            if (p == MimicA.mimicA) infos.Add(mimicA);
            if (p == BomberA.bomberA) infos.Add(bomberA);
            if (p == BomberB.bomberB) infos.Add(bomberB);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer) infos.Add(lawyer); // && !Lawyer.isProsecutor
            //if (p == Lawyer.lawyer && Lawyer.isProsecutor) infos.Add(prosecutor);
            //if (p == Trapper.trapper) infos.Add(trapper);
            if (p == Pursuer.pursuer) infos.Add(pursuer);
            if (p == Thief.thief) infos.Add(thief);

            // Default roles (just impostor, just crewmate, or hunter / hunted for hide n seek
            if (infos.Count == count) {
                if (p.Data.Role.IsImpostor)
                    infos.Add(TORMapOptions.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunter : RoleInfo.impostor);
                else
                    infos.Add(TORMapOptions.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunted : RoleInfo.crewmate);
            }

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true, bool suppressGhostInfo = false, bool includeHidden = false) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier, includeHidden: includeHidden).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) 
                roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            if (HandleGuesser.isGuesserGm && HandleGuesser.isGuesser(p.PlayerId)) roleName += " (Guesser)";

            if (!suppressGhostInfo && p != null) {
                if (p == Shifter.shifter && (CachedPlayer.LocalPlayer.PlayerControl == Shifter.shifter || Helpers.shouldShowGhostInfo()) && Shifter.futureShift != null)
                    roleName += Helpers.cs(Color.yellow, " ← " + Shifter.futureShift.Data.PlayerName);
                if (p == Vulture.vulture && (CachedPlayer.LocalPlayer.PlayerControl == Vulture.vulture || Helpers.shouldShowGhostInfo()))
                    roleName = roleName + Helpers.cs(Vulture.color, $" ({Vulture.vultureNumberToWin - Vulture.eatenBodies} left)");
                if (Helpers.shouldShowGhostInfo()) {
                    if (Eraser.futureErased.Contains(p))
                        roleName = Helpers.cs(Color.gray, "(erased) ") + roleName;
                    if (Vampire.vampire != null && !Vampire.vampire.Data.IsDead && Vampire.bitten == p && !p.Data.IsDead)
                        roleName = Helpers.cs(Vampire.color, $"(bitten {(int)HudManagerStartPatch.vampireKillButton.Timer + 1}) ") + roleName;
                    if (Deputy.handcuffedPlayers.Contains(p.PlayerId))
                        roleName = Helpers.cs(Color.gray, "(cuffed) ") + roleName;
                    if (Deputy.handcuffedKnows.ContainsKey(p.PlayerId))  // Active cuff
                        roleName = Helpers.cs(Deputy.color, "(cuffed) ") + roleName;
                    if (p == Warlock.curseVictim)
                        roleName = Helpers.cs(Warlock.color, "(cursed) ") + roleName;
                    if (p == Assassin.assassinMarked)
                        roleName = Helpers.cs(Assassin.color, "(marked) ") + roleName;
                    if (Pursuer.blankedList.Contains(p) && !p.Data.IsDead)
                        roleName = Helpers.cs(Pursuer.color, "(blanked) ") + roleName;
                    if (Witch.futureSpelled.Contains(p) && !MeetingHud.Instance) // This is already displayed in meetings!
                        roleName = Helpers.cs(Witch.color, "☆ ") + roleName;
                    if (BountyHunter.bounty == p)
                        roleName = Helpers.cs(BountyHunter.color, "(bounty) ") + roleName;
                    if (Arsonist.dousedPlayers.Contains(p))
                        roleName = Helpers.cs(Arsonist.color, "♨ ") + roleName;
                    if (p == Arsonist.arsonist)
                        roleName = roleName + Helpers.cs(Arsonist.color, $" ({CachedPlayer.AllPlayers.Count(x => { return x.PlayerControl != Arsonist.arsonist && !x.Data.IsDead && !x.Data.Disconnected && !Arsonist.dousedPlayers.Any(y => y.PlayerId == x.PlayerId); })} left)");
                    if (p == Jackal.fakeSidekick)
                        roleName = Helpers.cs(Sidekick.color, $" (fake SK)") + roleName;

                    // Death Reason on Ghosts
                    if (p.Data.IsDead) {
                        string deathReasonString = "";
                        var deadPlayer = GameHistory.deadPlayers.FirstOrDefault(x => x.player.PlayerId == p.PlayerId);

                        Color killerColor = new();
                        if (deadPlayer != null && deadPlayer.killerIfExisting != null) {
                            killerColor = RoleInfo.getRoleInfoForPlayer(deadPlayer.killerIfExisting, false).FirstOrDefault().color;
                        }

                        if (deadPlayer != null) {
                            switch (deadPlayer.deathReason) {
                                case DeadPlayer.CustomDeathReason.Disconnect:
                                    deathReasonString = " - disconnected";
                                    break;
                                case DeadPlayer.CustomDeathReason.Exile:
                                    deathReasonString = " - voted out";
                                    break;
                                case DeadPlayer.CustomDeathReason.Kill:
                                    deathReasonString = $" - killed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Guess:
                                    if (deadPlayer.killerIfExisting.Data.PlayerName == p.Data.PlayerName)
                                        deathReasonString = $" - failed guess";
                                    else
                                        deathReasonString = $" - guessed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Shift:
                                    deathReasonString = $" - {Helpers.cs(Color.yellow, "shifted")} {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.WitchExile:
                                    deathReasonString = $" - {Helpers.cs(Witch.color, "witched")} by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LoverSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lovers.color, "lover died")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Revenge:
                                    deathReasonString = $" - {Helpers.cs(NekoKabocha.color, "revenged")} by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Suicide:
                                    deathReasonString = $" - suicide";
                                    break;
                                //case DeadPlayer.CustomDeathReason.LawyerSuicide:
                                //deathReasonString = $" - {Helpers.cs(Lawyer.color, "bad Lawyer")}";
                                //break;
                                case DeadPlayer.CustomDeathReason.Bomb:
                                    deathReasonString = $" - bombed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Arson:
                                    deathReasonString = $" - burnt by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                            }
                            roleName = roleName + deathReasonString;
                        }
                    }
                }
            }
            return roleName;
        }
    }
}
