<?php

namespace App\COntrollers;
use CodeIgniter\Controller;

// include("./app/Views/templates/header.php");
// include("./app/Views/templates/footer.php");

class Testing extends Controller
{
    public function index()
    {
        $data = [
            'title' => 'Hi! This is my CI Project:)',
            'content' => 'Welcome to this page. This is a sample page for my first CodeIgniter project.
                          This project was created using CodeIgniter, a powerful and fast PHP framework.
                          You can easily develop dynamic web applications using CodeIgniter.
                          Hopefully, this project helps you understand the basics of web development with CodeIgniter.'
        ];

        return view('templates/header', $data) .
               view('test_view', $data) .
               view('templates/footer', $data);
    }
}
