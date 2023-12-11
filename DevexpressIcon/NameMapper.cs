namespace DevexpressIcon;

internal class NameMapper
{
    #region singleton

    private static readonly Lazy<NameMapper> _instance = new(() => new NameMapper());

    public static NameMapper Instance => _instance.Value;

    private NameMapper()
    {
        _dictionary.Add(Icon.About, IconName.About);
        _dictionary.Add(Icon.Accept, IconName.Accept);
        _dictionary.Add(Icon.Add, IconName.Add);
        _dictionary.Add(Icon.Address, IconName.Address);
        _dictionary.Add(Icon.Alert, IconName.Alert);
        _dictionary.Add(Icon.AlignCenter, IconName.AlignCenter);
        _dictionary.Add(Icon.AlignLeft, IconName.AlignLeft);
        _dictionary.Add(Icon.AlignRight, IconName.AlignRight);
        _dictionary.Add(Icon.Birthdate, IconName.Birthdate);
        _dictionary.Add(Icon.Bold, IconName.Bold);
        _dictionary.Add(Icon.Bonus, IconName.Bonus);
        _dictionary.Add(Icon.Calendar, IconName.Calendar);
        _dictionary.Add(Icon.CaretLeft, IconName.CaretLeft);
        _dictionary.Add(Icon.CaretRight, IconName.CaretRight);
        _dictionary.Add(Icon.Check, IconName.Check);
        _dictionary.Add(Icon.ChevronDown, IconName.ChevronDown);
        _dictionary.Add(Icon.ChevronLeft, IconName.ChevronLeft);
        _dictionary.Add(Icon.ChevronLeftSmall, IconName.ChevronLeftSmall);
        _dictionary.Add(Icon.ChevronRight, IconName.ChevronRight);
        _dictionary.Add(Icon.ChevronRightSmall, IconName.ChevronRightSmall);
        _dictionary.Add(Icon.City, IconName.City);
        _dictionary.Add(Icon.Clear, IconName.Clear);
        _dictionary.Add(Icon.Close, IconName.Close);
        _dictionary.Add(Icon.Collapse, IconName.Collapse);
        _dictionary.Add(Icon.ColumnChooser, IconName.ColumnChooser);
        _dictionary.Add(Icon.Contacts, IconName.Contacts);
        _dictionary.Add(Icon.Copy, IconName.Copy);
        _dictionary.Add(Icon.CreditCard, IconName.CreditCard);
        _dictionary.Add(Icon.Cut, IconName.Cut);
        _dictionary.Add(Icon.DebitCard, IconName.DebitCard);
        _dictionary.Add(Icon.DocumentColor, IconName.DocumentColor);
        _dictionary.Add(Icon.Dollar, IconName.Dollar);
        _dictionary.Add(Icon.DropFile, IconName.DropFile);
        _dictionary.Add(Icon.Euro, IconName.Euro);
        _dictionary.Add(Icon.Export, IconName.Export);
        _dictionary.Add(Icon.ExportJpg, IconName.ExportJpg);
        _dictionary.Add(Icon.ExportPdf, IconName.ExportPdf);
        _dictionary.Add(Icon.ExportPng, IconName.ExportPng);
        _dictionary.Add(Icon.Folder, IconName.Folder);
        _dictionary.Add(Icon.FolderColor, IconName.FolderColor);
        _dictionary.Add(Icon.Font, IconName.Font);
        _dictionary.Add(Icon.GridToolbarDelete, IconName.GridToolbarDelete);
        _dictionary.Add(Icon.GridToolbarDocument, IconName.GridToolbarDocument);
        _dictionary.Add(Icon.GridToolbarEdit, IconName.GridToolbarEdit);
        _dictionary.Add(Icon.GridToolbarFilter, IconName.GridToolbarFilter);
        _dictionary.Add(Icon.GridToolbarNew, IconName.GridToolbarNew);
        _dictionary.Add(Icon.GridToolbarRefresh, IconName.GridToolbarRefresh);
        _dictionary.Add(Icon.Home, IconName.Home);
        _dictionary.Add(Icon.ImageColors, IconName.ImageColors);
        _dictionary.Add(Icon.Info, IconName.Info);
        _dictionary.Add(Icon.Italic, IconName.Italic);
        _dictionary.Add(Icon.Like, IconName.Like);
        _dictionary.Add(Icon.Link, IconName.Link);
        _dictionary.Add(Icon.LogoColor, IconName.LogoColor);
        _dictionary.Add(Icon.LogoMonochrome, IconName.LogoMonochrome);
        _dictionary.Add(Icon.Mail, IconName.Mail);
        _dictionary.Add(Icon.Minus, IconName.Minus);
        _dictionary.Add(Icon.Music, IconName.Music);
        _dictionary.Add(Icon.MusicColors, IconName.MusicColors);
        _dictionary.Add(Icon.Paragraph, IconName.Paragraph);
        _dictionary.Add(Icon.Paste, IconName.Paste);
        _dictionary.Add(Icon.Phone, IconName.Phone);
        _dictionary.Add(Icon.Plus, IconName.Plus);
        _dictionary.Add(Icon.PopupBirthday, IconName.PopupBirthday);
        _dictionary.Add(Icon.PopupPosition, IconName.PopupPosition);
        _dictionary.Add(Icon.PopupUser, IconName.PopupUser);
        _dictionary.Add(Icon.PopupWorked, IconName.PopupWorked);
        _dictionary.Add(Icon.Products, IconName.Products);
        _dictionary.Add(Icon.Quest, IconName.Quest);
        _dictionary.Add(Icon.Redo, IconName.Redo);
        _dictionary.Add(Icon.Refresh, IconName.Refresh);
        _dictionary.Add(Icon.Save, IconName.Save);
        _dictionary.Add(Icon.SchedulerAdd, IconName.SchedulerAdd);
        _dictionary.Add(Icon.SchedulerDelete, IconName.SchedulerDelete);
        _dictionary.Add(Icon.SchedulerDragAndResize, IconName.SchedulerDragAndResize);
        _dictionary.Add(Icon.SchedulerDragBetweenResources, IconName.SchedulerDragBetweenResources);
        _dictionary.Add(Icon.SchedulerEdit, IconName.SchedulerEdit);
        _dictionary.Add(Icon.SchedulerNavigator, IconName.SchedulerNavigator);
        _dictionary.Add(Icon.SchedulerNoTooltip, IconName.SchedulerNoTooltip);
        _dictionary.Add(Icon.Search, IconName.Search);
        _dictionary.Add(Icon.Settings, IconName.Settings);
        _dictionary.Add(Icon.Sort, IconName.Sort);
        _dictionary.Add(Icon.Support, IconName.Support);
        _dictionary.Add(Icon.ThemeIcon, IconName.ThemeIcon);
        _dictionary.Add(Icon.Time, IconName.Time);
        _dictionary.Add(Icon.Total, IconName.Total);
        _dictionary.Add(Icon.Underline, IconName.Underline);
        _dictionary.Add(Icon.Undo, IconName.Undo);
        _dictionary.Add(Icon.UserProfile, IconName.UserProfile);
        _dictionary.Add(Icon.Video, IconName.Video);
        _dictionary.Add(Icon.VideoColors, IconName.VideoColors);
        _dictionary.Add(Icon.Watermark, IconName.Watermark);
    }

    #endregion

    private readonly Dictionary<Icon, string> _dictionary = new();

    public string this[Icon name] => _dictionary[name];
}