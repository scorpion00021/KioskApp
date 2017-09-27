﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

using ZXing;
using ZXing.Client.Result;
using ZXing.Common;
using ZXing.PDF417.Internal;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using System.Text.RegularExpressions;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private BarcodeReader barcodeReader = new BarcodeReader
        {
            AutoRotate = true,
            TryInverted = true,
            Options = new DecodingOptions { TryHarder = true }
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WhatNext()
        {
            return View();
        }

        public ActionResult Scan()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult CheckBarcode(string imgBase64)
        {
            var base64Data = Regex.Match(imgBase64, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
            byte[] imageAsBytes = Convert.FromBase64String(base64Data);
            MemoryStream streamBitmap = new MemoryStream(imageAsBytes);
            Bitmap bitImage = new Bitmap((Bitmap)Image.FromStream(streamBitmap));
            var result = Decode(bitImage, null);
            if (result != "")
            {
                Console.WriteLine(result);
                //determine if QR code is valid HERE
                return Json(new { success = true, responseText = result }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { success = false, responseText = "NO QR FOUND" }, JsonRequestBehavior.AllowGet);
        }

        private string Decode(Bitmap bitmap, IList<BarcodeFormat> possibleFormats)
        {
            if (possibleFormats != null)
                barcodeReader.Options.PossibleFormats = possibleFormats;

            var result = barcodeReader.Decode(bitmap);
            if (result != null)
            {
                return result.Text;
            }
            else
            {
                return "";
            }
        }
    }
}