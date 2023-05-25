# Note: This fork makes little effort developing new features.

## This fork is tend to migrate the project to that of a modern .NET application and do more often releases.

### The followings have been done to migrate this appliction to new .NET Sdk Project style.

- The projects `ArcFormats`,`GameRes`,`GARbro.GUI`,`Net20` has been migrated to new sdk style `csproj`, and targets `.NET Framework 4.8`
- the `.gitattributes` and `.gitignore` has been replaced with the defaults of VS2022.
- The `ArcFormats\Resources\Formats.dat` has been renamed to `ArcFormats\GameData\Formats.dat` so that the msbuild's `COPY` operation can directly do the copy to the right path.
- Project references relations has been changed, and the old namespace overwriten rule is deprecated in new sdk.
- Nuget packages are now managed by `csproj` `PackageReference` Keys, so all `packages.config` files are deleted.

### The followings will be done to continue upgrade .NET runtime to latest .NET 6 / 7

- Some of the packages references still don't support .NET Standard yet. Future plans are to replace them with newer implmentations.

---

---

# GARbro

Visual Novels resource browser.

Requires .NET Framework v4.6 or newer (https://www.microsoft.com/net)

[Supported formats](https://morkt.github.io/GARbro/supported.html)

[Download latest release](https://github.com/morkt/GARbro/releases)

## Operation

Browse through the file system to a file of interest. If you think it's an
archive, try to 'enter' inside by pressing 'Enter' on it. If GARbro
recognizes format its contents will be displayed just like regular file
system. Some archives are encrypted, so you will be asked for credentials or
a supposed game title. If game is not listed among presented options then
most likely archive could not be opened by current GARbro version.

Files could be extracted from archives by pressing 'F4', with all images and
audio converted to common formats in the process, of course if game format
itself is recognized.

When displaying file system contents GARbro assigns types to files based on
their names extension (so it's not always correct). If types are misapplied,
it could be changed by selecting files and assigning type manually via context
menu 'Assign file type'.

## GUI Hotkeys

<table>
<tr><td><kbd>Enter</kbd></td><td>                   Try to open selected file as archive -OR- playback audio file</td></tr>
<tr><td><kbd>Ctrl</kbd>+<kbd>PgDn</kbd></td><td>    Try to open selected file as archive</td></tr>
<tr><td><kbd>Ctrl</kbd>+<kbd>E</kbd></td><td>       Open current folder in Windows Explorer</td></tr>
<tr><td><kbd>Backspace</kbd></td><td>               Go back</td></tr>
<tr><td><kbd>Alt</kbd>+<kbd>&rarr;</kbd></td><td>   Go forward</td></tr>
<tr><td><kbd>Ctrl</kbd>+<kbd>PgUp</kbd></td><td>    Go to parent directory</td></tr>
<tr><td><kbd>Ctrl</kbd>+<kbd>O</kbd></td><td>       Choose file to open as archive</td></tr>
<tr><td><kbd>Ctrl</kbd>+<kbd>A</kbd></td><td>       Select all files</td></tr>
<tr><td><kbd>Space</kbd></td><td>                   Select next file</td></tr>
<tr><td><kbd>Numpad +</kbd></td><td>                Select files matching specified mask</td></tr>
<tr><td><kbd>F3</kbd></td><td>                      Create archive</td></tr>
<tr><td><kbd>F4</kbd></td><td>                      Extract selected files</td></tr>
<tr><td><kbd>F5</kbd></td><td>                      Refresh view</td></tr>
<tr><td><kbd>F6</kbd></td><td>                      Convert selected files</td></tr>
<tr><td><kbd>Delete</kbd></td><td>                  Delete selected files</td></tr>
<tr><td><kbd>Ctrl</kbd>+<kbd>H</kbd></td><td>       Fit window to a displayed image</td></tr>
<tr><td><kbd>Alt</kbd>+<kbd>Shift</kbd>+<kbd>M</kbd></td><td>   Hide menu bar</td></tr>
<tr><td><kbd>Alt</kbd>+<kbd>Shift</kbd>+<kbd>T</kbd></td><td>   Hide tool bar</td></tr>
<tr><td><kbd>Alt</kbd>+<kbd>Shift</kbd>+<kbd>S</kbd></td><td>   Hide status bar</td></tr>
<tr><td><kbd>Ctrl</kbd>+<kbd>S</kbd></td><td>       Toggle scaling of large images</td></tr>
<tr><td><kbd>Ctrl</kbd>+<kbd>Q</kbd></td><td>       Exit</td></tr>
</table>

## Author

Written by [morkt](https://github.com/morkt/GARbro) under [MIT License](https://github.com/morkt/GARbro/blob/master/LICENSE).

Korean translation by [mireado](https://github.com/mireado), [overworks](https://github.com/overworks)

Simplified Chinese translation by [elasticblitz](https://github.com/elasticblitz), [PeratX](https://github.com/PeratX) and [taroxd](https://github.com/taroxd)

Japanese translation by [haniwa55](https://github.com/haniwa55)
