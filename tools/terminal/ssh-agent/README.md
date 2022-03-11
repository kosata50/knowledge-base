# SSH Agent

Instrucstions:
- https://4sysops.com/archives/powershell-remoting-with-ssh-public-key-authentication/
- https://docs.microsoft.com/en-us/windows-server/administration/openssh/openssh_keymanagement

## Setup

``` ps
ssh-keygen -t rsa
```

### Run agent

``` ps
Set-Service ssh-agent -StartupType Automatic
Start-Service ssh-agent
```

Manually add key to agent:

``` ps
ssh-add [path_to_private_key]
```
