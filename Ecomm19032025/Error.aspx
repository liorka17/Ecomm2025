<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Ecomm19032025.Error" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>מה עשית לעצמך</title>
    <meta charset="utf-8" />
    <style>
        body {
            background: linear-gradient(to bottom, #330000, #000000);
            color: #fff;
            font-family: 'Segoe UI', sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
            text-align: center;
            height: 100vh;
            margin: 0;
            direction: rtl;
        }

        .box {
            background-color: rgba(0, 0, 0, 0.85);
            padding: 50px;
            border-radius: 20px;
            max-width: 600px;
            box-shadow: 0 0 30px #ff0000;
        }

        .emoji {
            font-size: 4rem;
            margin-bottom: 20px;
        }

        #shameText {
            font-size: 1.3rem;
            line-height: 2;
            color: #ffdddd;
            min-height: 100px;
        }

        .countdown {
            margin-top: 30px;
            font-size: 1rem;
            color: #aaa;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="box">
            <div class="emoji">😐🫣🧻</div>
            <h1>ניסיון גישה בלי סיסמה</h1>
            <div id="shameText">טוען את רמת האכזבה...</div>
            <div class="countdown">הפנייה אוטומטית לעמוד ההתחברות תתבצע בעוד <span id="counter">27</span> שניות.</div>
        </div>
    </form>

    <script>
        const texts = [
            "טוב, נתחיל בזה – אתה ניסית להיכנס בלי סיסמה. באמת.",
            "זה כמו לנסות להיכנס למעלית בלי בניין.",
            "זה לא 'שכחת סיסמה', זה שכחת מחשבה.",
            "תאר לעצמך שאתה פורץ לחנות ואומר 'שכחתי את הפנים שלי'.",
            "המחשב שלך התבייש בך. העכבר ניתק את עצמו.",
            "אפילו השרת של האתר פלט אנחת ייאוש.",
            "אנחנו לא כועסים. אנחנו פשוט שוקלים למחוק אותך מהאינטרנט.",
            "האח הגדול ראה את זה – והוא שלח פקס לאמא שלך.",
            "בבקשה. לך, תחשוב. ואל תחזור לפה בלי סיסמה."
        ];

        let index = 0;
        let seconds = texts.length * 3; // זמן כולל – הודעה כל 3 שניות
        const shameText = document.getElementById("shameText");
        const counter = document.getElementById("counter");

        // מעדכן טקסט השפלה כל 3 שניות
        const textInterval = setInterval(() => {
            if (index < texts.length) {
                shameText.textContent = texts[index++];
            }
        }, 3000);

        // מעדכן ספירה לאחור כל שנייה
        const countdownInterval = setInterval(() => {
            seconds--;
            counter.textContent = seconds;
            if (seconds <= 0) {
                clearInterval(textInterval);
                clearInterval(countdownInterval);
                window.location.href = "LoginPage.aspx";
            }
        }, 1000);
    </script>
</body>
</html>
