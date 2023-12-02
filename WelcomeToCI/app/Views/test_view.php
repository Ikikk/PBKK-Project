<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?=$title; ?></title>
    <style>
        body .isi {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            padding: 20px;
        }
        h1 {
            color: #333;
            font-size: 24px;
            padding: 20px;
        }
        p {
            font-size: 16px;
            line-height: 1.5;
            text-align: justify;
        }
    </style>
</head>
<body>
    <h1><?=$title; ?></h1>
    <p style="font-size: 20px;" class="isi"><?=$content; ?></p>
</body>
</html>