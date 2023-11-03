<!DOCTYPE html>
<html>
<head>
    <title>First CI Project</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style> 
        /* Add CSS to style the footer and separate content */
        footer {
            background-color: #333;
            color: #fff;
            padding: 20px;
            position: absolute;
            bottom: 0;
            width: 97.3%;
            /* max-height: 15vh; Adjust this value to fit your design */
            overflow: hidden;
        }

        footer .container {
            text-align: left;
            /* max-height: 100%; */
        }

        footer h3 {
            font-size: 24px;
            margin-top: 10px;
        }

        footer p {
            font-size: 16px;
            margin: 5px;
        }

        /* Separate Contact Person and Follow Me sections */
        footer .row {
            display: flex;
            justify-content: space-between;
            align-items: center;
            
        }

        /* Style Follow Me section on the right */
        footer .col-md-6:last-child {
            text-align: right;
        }

        footer a {
            text-decoration: none;
            color: #fff;
            font-weight: bold;
            margin: 5px;
        }


        footer a:hover {
            text-decoration: underline;
        }


    </style>
</head>

<footer >
  <div class="container">
    <div class="row">
      <div class="col-md-6">
        <h3>Contact Person</h3>
        <p>Rizky Alifiyah Rahma - 5025211208</p>
        <p>Informatics Engineering</p>
        <p>Surabaya, Indonesia</p>
        <p>Email: 5025211208@student.its.ac.id</p>
      </div>

      <div class="col-md-6">
        <h3>Follow Me</h3>
            <a href="#">Linkedin</a>
            <a href="#">Twitter</a>
            <a href="#">Instagram</a>
      </div>
    </div>
  </div>
</footer>
</body>