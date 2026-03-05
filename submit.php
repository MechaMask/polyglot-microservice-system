<?php
$db = new PDO('sqlite:feedback.db');

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $user = $_POST['user'] ?? 'Anonymous';
    $msg = $_POST['message'] ?? '';

    if (!empty($msg)) {
        $stmt = $db->prepare("INSERT INTO Feedback (User, Message) VALUES (?, ?)");
        $stmt->execute([$user, $msg]);
        echo json_encode(["status" => "success"]);
    }
}
?>