# KMS Patrina

KMS Patrina implements practically permanent KMS activation for the latest Microsoft Windows and Office.

![KMS Patrina preview](https://images2.imgbox.com/0d/29/GsI9fE6w_o.png)



# Software features

- Only touches the SPP store file (data.dat).

- Offline KMS activation for local or other PCs.

- Sets the KMS grace period spanning multiple centuries.

The advantage of using offline KMS activation with unlicensed Microsoft products is that it does not rely on the Internet or any third-party service, and covers the entire product line (Windows, Windows Server and Office), which is more appealing than any other known method. Copy-over and back "data.dat" is enough to activate other computers - they don't even need to run anything.

For practical considerations, I've set the default grace period from 1900-01-01 to 2199-12-31, which covers all possibilities of intentional or unintentional system time adjustments, ensuring the activation won't drop. And I have totally no interest on things like setting the activation to the year AD 6100 just for fun.


# System requirements

This project is targeting activation of the following product editions that can have a GVLK installed:

- Windows 10 and above

- Windows Server 2022 and above

- Office/Project/Visio 2021 and above

Unlike those stamp-collecting enthusiasts, I have absolutely no interest on some expired operating systems, as they are lacking of practical purpose. So if you want to implement long-term KMS activation on Windows 8.1 and earlier, please directly head over to the TSforge project (see the Open Source section).

Similarly, when you already have a fairly complete or even the most feature-rich software edition, as a non-stamp-collecting enthusiast, you don't want to bother with other editions. For Windows, you are expected to use the Professional, Education or Enterprise edition (Datacenter for Windows Server). For Office, you are expected to use the LTSC Professional Plus edition. These editions are well supported for KMS activation, hence there is absolutely no need for you to trouble with Retail or less-featured editions that do not support KMS.


# How it works

Somehow hackers got the RSA key to decrypt the SPP store file (data.dat).

So we can put fake universal KMS activation data and fake timestamp for each product.

Microsoft KMS timestamp allows a maximum duration about approximately 4083 years.

We can then set the ideal grace period.

By the way, I've tried to only tamper the timestamp without touching the corresponding activation data stored from a real KMS activation process, and it simply works. This perfectly proves that the minimum modification requirement for a long-term KMS only involves changing of three timestamps (a total of 24 bytes), as long as you have already gone through a legitimate KMS activation process and trying to turn it from a short-term (180-day) into a long-term (180 years or whatever).


# Configurations

Currently, I do not want to make things complicated, and I only use a "product.txt" file to describe products that need to be activated. You need to create this file yourself, as I should not directly provide any convenience for illegal activations.

The first line is the name of the SPP store file (data.dat) you want to patch. You can just enter a file name to indicate a file in the current directory, or you can provide the full file path. This determines whether you are activating for the local machine or another computer (in which case, you only need to copy over "data.dat").

Next, you have to define each product's friendly name (optional), Application ID and SKU ID (also known as Activation ID). Find these IDs yourself and hint - Application IDs for Windows and Office are fixed as below.

A complete example "product.txt" file is shown below, and of course you can process multiple products at once.

```
data.dat

[Windows Server 2025 Datacenter]
55c92734-d682-4d71-983e-d6ec3f16059f
c052f164-cdf6-409a-a0cb-853ba0f0f55a

[Office LTSC Professional Plus 2024]
0ff1ce15-a989-479d-af46-f275c6370663
8d368fc1-9470-4be2-8d66-90e836cbb051

[Project Professional 2024]
0ff1ce15-a989-479d-af46-f275c6370663
fa187091-8246-47b1-964f-80a0b1e5d69a

[Visio LTSC Professional 2024]
0ff1ce15-a989-479d-af46-f275c6370663
f510af75-8ab7-4426-a236-1bfb95c34ff8
```

You need to make sure that all required GVLKs have been inserted before processing the "data.dat" file. If you encounter a situation where the "data.dat" file is in use, please wait a while and try again. After you overwrite "data.dat", you must immediately run "slmgr.vbs /xpr" or "ospp.vbs /dstatus" to make the activation valid, but restart the PC is also a good option.

By default, you can find "data.dat" in the "C:\Windows\System32\spp\store\2.0" directory, but if you want set to directly patch this file within "product.txt", you need to use the path "C:\Windows\Sysnative\spp\store\2.0\data.dat".


# Usage examples

**Windows**

- Step 1: Enter your Windows edition's GVLK in the Settings app, which can be found on the Microsoft official website: 
https://learn.microsoft.com/en-us/windows-server/get-started/kms-client-activation-keys

![Windows step 1 preview](https://thumbs2.imgbox.com/99/fb/TE2jx7GI_t.png)

- Step 2: Click the "Activate" button.

![Windows step 2 preview](https://thumbs2.imgbox.com/9b/23/mVOnaEkh_t.png)

- Step 3: It will prompt you that activation has failed, which is totally normal and is expected. You can simply "Close" the dialog.

![Windows step 3 preview](https://thumbs2.imgbox.com/60/7d/p8E5wbHU_t.png)

- Step 4: Run KMS Patrina (as administrator, if you are activating for the local machine).

```
Process: C:\Windows\Sysnative\spp\store\2.0\data.dat
AES-CBC Key: 0x0B20AFC0B5097561233862BD4998F7E6
HMAC-SHA1 Key: 0x7CCD2703C185401F8DD2B0034CDDAF73

Windows Server 2025 Datacenter
Application ID: 55c92734-d682-4d71-983e-d6ec3f16059f
Product SKU ID: c052f164-cdf6-409a-a0cb-853ba0f0f55a
Product status updated.

File has been updated.
```

- Step 5: Check with "slmgr.vbs /xpr", you will see that it is activated until the next century. Then you will notice that the Activation state changes to "Active".

![Windows step 5 preview](https://thumbs2.imgbox.com/2c/ff/p6R3qZfx_t.png)

**Office / Project / Visio**

- Step 1: If you performed a Retail installation, you need to execute some commands to convert Retail license to KMS license. The following are examples for Office, Project and Visio 2024 (or find the GVLK for your Office version somewhere):

```
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\ProPlus2024VL_KMS_Client_AE-ppd.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\ProPlus2024VL_KMS_Client_AE-ul.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\ProPlus2024VL_KMS_Client_AE-ul-oob.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inpkey:XJ2XN-FW8RK-P4HMP-DKDBV-GCVGB

cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\ProjectPro2024VL_KMS_Client_AE-ppd.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\ProjectPro2024VL_KMS_Client_AE-ul.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\ProjectPro2024VL_KMS_Client_AE-ul-oob.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inpkey:FQQ23-N4YCY-73HQ3-FM9WC-76HF4

cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\VisioPro2024VL_KMS_Client_AE-ppd.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\VisioPro2024VL_KMS_Client_AE-ul.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inslic:"C:\Program Files\Microsoft Office\root\Licenses16\VisioPro2024VL_KMS_Client_AE-ul-oob.xrm-ms"
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /inpkey:B7TN8-FJ8V3-7QYCP-HQPMV-YY89G
```

- Step 2: You also need to do this to prevent Microsoft countermeasures against fake KMS activation from taking effect (you can set your favorite but non-working IP):

```
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /sethst:192.0.2.0
```

- Step 3: Run KMS Patrina (as administrator, if you are activating for the local machine).

```
Process: C:\Windows\Sysnative\spp\store\2.0\data.dat
AES-CBC Key: 0x06AEC1AAD095BF1AECC286FE46872155
HMAC-SHA1 Key: 0x0F3B1FE65262EB6703DCFE33E6963CCB

Office LTSC Professional Plus 2024
Application ID: 0ff1ce15-a989-479d-af46-f275c6370663
Product SKU ID: 8d368fc1-9470-4be2-8d66-90e836cbb051
Product status updated.

File has been updated.
```

- Step 4: Check Office activation results

```
cscript "C:\Program Files\Microsoft Office\Office16\OSPP.VBS" /dstatus
```

```
---Processing--------------------------
---------------------------------------
PRODUCT ID: 00502-40000-00000-AA983
SKU ID: 8d368fc1-9470-4be2-8d66-90e836cbb051
LICENSE NAME: Office 24, Office24ProPlus2024VL_KMS_Client_AE edition
LICENSE DESCRIPTION: Office 24, VOLUME_KMSCLIENT channel
BETA EXPIRATION: 1601/1/1
LICENSE STATUS:  ---LICENSED---
REMAINING GRACE: 63685 days  (91706830 minute(s) before expiring)
Last 5 characters of installed product key: GCVGB
Activation Type Configuration: ALL
        DNS auto-discovery: KMS name not available
        KMS machine registry override defined: 192.0.2.0:1688
        Activation Interval: 120 minutes
        Renewal Interval: 10080 minutes
        KMS host caching: Enabled
---------------------------------------
---------------------------------------
---Exiting-----------------------------
```


# Open source

KMS Patrina is a re-implementation of the KMS4k activation method in project TSforge. All its core data comes from the following project:

https://github.com/massgravel/TSforge

Many thanks.

The reason I wanted to implement this thing myself is that the original project considered too many versions that are detached from practical usage, which made the whole script a tangled mess. Therefore, I've just created a light-weighted version, a single Module using pure VB.NET and pure functions, without any classes or structures, implementing only the core functionality. Such easy-to-review and edit approach is better suited for our workhorse machines.


# Legal disclaimer

This project is provided for educational and research purposes only. It is intended to demonstrate and explore the principles behind Microsoft software activation (SPP). The author does not encourage or condone the use of this project for unauthorized activation of Microsoft products. Users are solely responsible for complying with applicable laws and licensing terms in their jurisdiction. By using this project, you acknowledge that it is meant for study, experimentation, and technical learning, and not for commercial or illegal use.
