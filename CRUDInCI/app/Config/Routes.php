<?php

use CodeIgniter\Router\RouteCollection;

/**
 * @var RouteCollection $routes
 */
$routes->get('/', 'Home::index', ['as' => 'home']);
$routes->get('/home/create', 'Home::create');
$routes->match(['get', 'post'], '/home/create', 'Home::create', ['as' => 'create']);
$routes->get('/home/update/(:num)', 'Home::update/$1');
$routes->match(['get', 'post'], '/home/update/(:num)', 'Home::update/$1', ['as' => 'update']);
$routes->get('/home/delete/(:num)', 'Home::delete/$1');