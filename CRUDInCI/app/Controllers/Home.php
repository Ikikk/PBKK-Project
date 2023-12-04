<?php

namespace App\Controllers;

class Home extends BaseController
{
    public function index(): string
    {
        $db = \Config\Database::connect();
        $data['karyawan'] = $db->table('karyawan')->get()->getResultArray();
        return view('masters/header') . view('home', $data) . view('masters/footer');
    }

    public function create()
    {
        $db = \Config\Database::connect();
        if ($this->request->getServer('REQUEST_METHOD') === 'POST') {
            $data = $this->request->getPost();
            $db->table('karyawan')->insert($data);
            return redirect()->to(base_url('/'));
        } 
        return view('masters/header') . view('create') . view('masters/footer');
    }

    public function update($id)
    {
        $db = \Config\Database::connect();
        if ($this->request->getServer('REQUEST_METHOD') === 'POST') {
            $data = $this->request->getPost();
            $db->table('karyawan')->where('id', $id)->update($data);
            return redirect()->to(base_url('/'));
        } else {
            $data['item'] = $db->table('karyawan')->getWhere(['id' => $id])->getRow();
            return view('masters/header') . view('update', $data) . view('masters/footer');
        }
    }

    public function delete($id)
    {
        $db = \Config\Database::connect();
        $db->table('karyawan')->where('id', $id)->delete();
        return redirect()->to(base_url('/'));
    }
}
