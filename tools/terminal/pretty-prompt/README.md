# Pretty prompt

Instructions: 
- https://www.hanselman.com/blog/how-to-make-a-pretty-prompt-in-windows-terminal-with-powerline-nerd-fonts-cascadia-code-wsl-and-ohmyposh
- https://docs.microsoft.com/en-us/windows/terminal/tutorials/powerline-setup

## Install

``` ps
Install-Module posh-git -Scope CurrentUser
Install-Module oh-my-posh -Scope CurrentUser
```


### Profile

`notepad $PROFILE`

``` ps
Import-Module posh-git
Import-Module oh-my-posh
Set-Theme Paradox
```

Fix czech characters:
``` ps
$env:LC_ALL = 'C.UTF-8'
```