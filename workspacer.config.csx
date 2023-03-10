#r "C:\Program Files\workspacer\workspacer.Shared.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.Bar\workspacer.Bar.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.ActionMenu\workspacer.ActionMenu.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.FocusIndicator\workspacer.FocusIndicator.dll"

using System;
using workspacer;
using workspacer.Bar;
using workspacer.ActionMenu;
using workspacer.FocusIndicator;

Action<IConfigContext> doConfig = (context) =>
{
    context.AddBar();
    context.AddFocusIndicator();
    var actionMenu = context.AddActionMenu();

    context.WorkspaceContainer.CreateWorkspace("1-Base", new FullLayoutEngine(), new TallLayoutEngine()); 
    context.WorkspaceContainer.CreateWorkspace("2-Dev", new FullLayoutEngine(), new TallLayoutEngine()); 
    context.WorkspaceContainer.CreateWorkspace("3-Comm", new TallLayoutEngine(), new FullLayoutEngine()); 
    context.WorkspaceContainer.CreateWorkspace("4-Web", new TallLayoutEngine(), new FullLayoutEngine()); 
    context.WorkspaceContainer.CreateWorkspace("5-Design", new FullLayoutEngine(), new TallLayoutEngine()); 
    context.WorkspaceContainer.CreateWorkspace("6-Tools", new FullLayoutEngine(), new TallLayoutEngine()); 
    context.WorkspaceContainer.CreateWorkspace("7-Office", new FullLayoutEngine(), new TallLayoutEngine()); 
    context.WorkspaceContainer.CreateWorkspace("8-Media", new FullLayoutEngine(), new TallLayoutEngine()); 
    context.WorkspaceContainer.CreateWorkspace("9-DB", new FullLayoutEngine(), new TallLayoutEngine()); 
    
    // My filter
    context.WindowRouter.AddFilter((window) => !window.Title.Contains("Копирование"));
    context.WindowRouter.AddFilter((window) => !window.Title.Contains("Screen Recorder"));
    context.WindowRouter.AddFilter((window) => !window.Title.Contains("Безопасность Windows"));
    context.WindowRouter.AddFilter((window) => !window.Title.Contains("Media viewer"));
    context.WindowRouter.AddFilter((window) => !window.Title.Contains("TopTracker"));
    context.WindowRouter.AddFilter((window) => !window.Title.Contains("Joxi"));

    // My route
    // context.WindowRouter.AddRoute((window) => window.Title.Contains("Screen Recorder") ? context.WorkspaceContainer["1-Base"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Total Commander") ? context.WorkspaceContainer["1-Base"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Firefox") ? context.WorkspaceContainer["1-Base"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Яндекс.Браузер") ? context.WorkspaceContainer["4-Web"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Google Chrome") ? context.WorkspaceContainer["1-Base"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Visual Studio") ? context.WorkspaceContainer["2-Dev"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Telegram") ? context.WorkspaceContainer["3-Comm"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("WhatsApp") ? context.WorkspaceContainer["3-Comm"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Скайп") ? context.WorkspaceContainer["3-Comm"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Skype") ? context.WorkspaceContainer["3-Comm"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Tixati") ? context.WorkspaceContainer["4-Web"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("телефон") ? context.WorkspaceContainer["4-Web"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Figma") ? context.WorkspaceContainer["5-Design"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("LibreCAD") ? context.WorkspaceContainer["5-Design"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Adobe Illustrator") ? context.WorkspaceContainer["5-Design"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Autodesk AutoCAD") ? context.WorkspaceContainer["5-Design"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Adobe Photoshop") ? context.WorkspaceContainer["5-Design"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("фотографий Windows") ? context.WorkspaceContainer["5-Design"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Windows PowerShell") ? context.WorkspaceContainer["6-Tools"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Эксперт") ? context.WorkspaceContainer["6-Tools"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Evernote") ? context.WorkspaceContainer["7-Office"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Obsidian") ? context.WorkspaceContainer["7-Office"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Office") ? context.WorkspaceContainer["7-Office"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Word") ? context.WorkspaceContainer["7-Office"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Excel") ? context.WorkspaceContainer["7-Office"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("PowerPoint") ? context.WorkspaceContainer["7-Office"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Adobe Reader") ? context.WorkspaceContainer["7-Office"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("VLC") ? context.WorkspaceContainer["8-Media"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Clementine") ? context.WorkspaceContainer["8-Media"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("VideoLAN") ? context.WorkspaceContainer["8-Media"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("bookradio.hostingradio.ru:8069/fm") ? context.WorkspaceContainer["8-Media"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("SQL") ? context.WorkspaceContainer["9-DB"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("sql") ? context.WorkspaceContainer["9-DB"] : null);
};
return doConfig;