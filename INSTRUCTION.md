# Instructions on how to use MORT with DeepLX. 
### New version (1.284.x)
1. Download the latest version of the original [DeepLX](https://github.com/OwO-Network/DeepLX/releases) and the latest pre-release version of my fork [MORT-DeepLX](https://github.com/Net2Fox/MORT-DeepLX/releases).
2. Run DeepLX. Do not close the DeepLX window or it will stop working.
3. Start MORT. Remember to dismiss all update notifications.
4. Go to the `General` tab and under `Type` under `Translation settings` select `DeepLX`.
5. You can leave the default Free Endpoin, or select Official Endpoint (makes little difference and translation quality). 
6. Click `Apply` in the main MORT window.
7. Done. Customize MORT to your liking and use it.

#### Custom URL
If you are hosting DeepLX on some server, or on a non-standard port, then follow these steps to put your URL.
1. Go to the `Additional` menu, go to `Advanced Settings`.
2. Go to the `Translation` tab, go to the very bottom.
3. In the `DeepLX` box, in the `URL:` field, set your full URL with port.
4. Click `Apply` in the `Advanced Settings` box. After, click `Apply` in the main MORT window.
5. Done. Now requests will be made to DeepLX at your specified URL.

#### Paid Endpoint
If you have a Pro subscription at DeepL, you can use it. To do this, you will need the `dl_session` cookie. This cookie can be pulled using browser extensions such as `Get cookies.txt LOCALLY`. Use with caution as the cookie may be compromised!
1. In the `General` tab, when DeepLX is selected, select `Paid Endpotin`.
2. Go to the `Additional` menu, go to `Advanced Settings`.
3. Go to the `Translation` tab, go to the very bottom.
4. In the `DeepLX` box, in the `dl_session` field, set your cookie value that you pulled from your browser.
4. Click `Apply` in the `Advanced Settings` box. After, click `Apply` in the main MORT window.
5. Done.

### Old verison (1.282.1)
1. Download the latest version of the [DeepLX-MORT](https://github.com/Net2Fox/DeepLX-MORT/releases) fork and [MORT-DeepLX](https://github.com/Net2Fox/MORT-DeepLX/releases).
2. Start DeepLX. Do not close the DeepLX window or it will stop working.
3. Run MORT. Be sure to reject all update notifications.
4. Go to the `General` tab and under `Type` under `Translation settings`, select `Custom API`.
5. Go to the `Additional` tab, and click `Advanced settings`.
6. In the new window that opens, go to `Translation`, go to the bottom. Check the `Use the same language code as Google Translator` option, and in the `URL :` line insert the following address: `http://localhost:1188/translate`.
7. Click `Apply` in the advanced settings menu, then click `Apply` in the main MORT window.
8. Done. Customize MORT however you want and use it.
