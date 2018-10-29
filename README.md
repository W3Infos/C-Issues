# C#-Issues
Types issues and Solvation

#.  The request was aborted:  Could not create SSL/TLS secure channel.
 

# Ans:
# Just add  in App.config  file 
# ---------------------------------------------------------------------
<runtime> <AppContextSwitchOverrides 	value="Switch.System.Net.DontEnableSchUseStrongCrypto=false" /> 
</runtime>

# ---------------------------------------------------------------------
Ref:
1. https://stackoverflow.com/questions/52296865/kb4344167-security-update-breaks-tls-code
2. https://www.youtube.com/watch?v=-dKKi4ey8wY
