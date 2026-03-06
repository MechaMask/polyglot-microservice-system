<?php
$db = new PDO('sqlite:../FeedbackDashboard/feedback.db');

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $user = $_POST['user'] ?? 'Anonymous';
    $msg = $_POST['message'] ?? '';

    if (!empty($msg)) {
    $stmt = $db->prepare("INSERT INTO Feedback (User, Message) VALUES (?, ?)");
    $stmt->execute([$user, $msg]);
    
    header('Content-Type: application/json');
    echo json_encode(["status" => "success"]);
    exit();
}
}
?>